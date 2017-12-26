using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlastFurnaceGuide.Controls
{
    public partial class BlastFurnacePanelControl : UserControl
    {
        public BlastFurnacePanelControl()
        {
            InitializeComponent();
            BlastFurnaceStepControls.Add(this.blastFurnaceStepControlStep1_control);
            BlastFurnaceStepControls.Add(this.blastFurnaceStepControlStep2_control);
            BlastFurnaceStepControls.Add(this.blastFurnaceStepControlStep3_control);
        }

        public List<BlastFurnaceStepControl> BlastFurnaceStepControls
        {
            get;
        } = new List<BlastFurnaceStepControl>();

        public string GuideName
        {
            get
            {
                return this.guideName_lbl.Text;
            }
            set
            {
                this.guideName_lbl.Text = value;
            }
        }

        public void AssignNextHotKey(Action<Object, KeyEventArgs> action)
        {
            this.KeyDown += new KeyEventHandler(action);
        }

        public void AssignNextStepBtnAction(Action<Object, EventArgs> action)
        {
            this.nextStep_btn.Click += new System.EventHandler(action);            
        }

        public void AssignPreviousStepBtnAction(Action<Object, EventArgs> action)
        {
            this.previousStep_btn.Click += new System.EventHandler(action);
        }
    }
}
