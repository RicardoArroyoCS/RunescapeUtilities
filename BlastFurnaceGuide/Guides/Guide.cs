using BlastFurnaceGuide.Config;
using BlastFurnaceGuide.Controls;
using BlastFurnaceGuide.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlastFurnaceGuide.Guides
{
    public abstract class Guide : IGuide
    {
        protected Guide(BlastFurnacePanelControl panelControl)
        {
            PanelControl = panelControl;
        }

        protected IProcess Process
        {
            get;
            set;
        }

        protected BlastFurnacePanelControl PanelControl
        {
            get;

        }

        protected List<BlastFurnaceStepControl> BlastFurnaceStepControls
        {
            get
            {
                List<BlastFurnaceStepControl> controls = new List<BlastFurnaceStepControl>();

                if (PanelControl != null)
                {
                    controls = PanelControl.BlastFurnaceStepControls;
                }

                return controls;
            }
        }

        protected void Initialize()
        {
            InitializeForm();
            InitializeActions();
        }

        private void InitializeActions()
        {
            PanelControl.AssignNextStepBtnAction((o, e)=>NextStep(o, e));

            Process.ResetControls_event += this.ResetControls;
            Process.UpdateControls_event += this.UpdateControls;

            BlastFurnaceGuideForm.KeyPressHandler = null;

            if (Configuration.NextHotKey != null)
            {
                BlastFurnaceGuideForm.KeyPressHandler = NextHotKey;
            }
        }

        private void InitializeForm()
        {
            List<Step> steps = Process.Steps;
            string stepNameFormat = "Step {0}";
            foreach (Step step in steps)
            {
                int stepNumber = step.StepNumber;


                if (stepNumber < BlastFurnaceStepControls.Count())
                {
                    ModifyStepControlPanelRequest request = new ModifyStepControlPanelRequest()
                    {
                        CoalBagLabel = step.ExpectedCoalBag.ToString(),
                        InventoryLabel = step.ExpectedInventory.ToString(),
                        StepNameLabel = string.Format(stepNameFormat, stepNumber + 1)
                    };

                    BlastFurnaceStepControls[stepNumber].ModifyStepControlPanel(request);
                }
            }
            BlastFurnaceStepControls.Skip(steps.Count()).Take(BlastFurnaceStepControls.Count()).ToList().ForEach(c => c.HidePanel());
        }

        public void NextStep(Object o, EventArgs e)
        {
            //int stepNum = Process.CurrentStepNumber;
            Process.PerformNextStep();       
        }

        private void NextHotKey(Object o, KeyEventArgs e)
        {
            if(e.KeyData == Configuration.NextHotKeyData)
            {
                NextStep(this, null);
            }
        }

        private void UpdateControls(Object o, EventArgs e)
        {
            if(o is IProcess process)
            {
                int stepNum = process.CurrentStepNumber;
                if (stepNum < this.BlastFurnaceStepControls.Count())
                {
                    BlastFurnaceStepControls[stepNum].ChangeState(true);
                }
            }
        }

        private void ResetControls(Object o, EventArgs e)
        {
            foreach(var control in BlastFurnaceStepControls)
            {
                control.ChangeState(false);
            }
        }

        public void NextStep()
        {
            throw new NotImplementedException();
        }
    }
}
