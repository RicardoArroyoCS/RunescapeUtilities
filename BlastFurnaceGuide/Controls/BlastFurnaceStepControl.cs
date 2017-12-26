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
    public partial class BlastFurnaceStepControl : UserControl
    {
        public BlastFurnaceStepControl()
        {
            InitializeComponent();
        }

        public void ModifyStepControlPanel(ModifyStepControlPanelRequest request)
        {
            this.coalBag1_lbl.Text = request.CoalBagLabel;
            this.inventory1_lbl.Text = request.InventoryLabel;
            this.stepNumber_lbl.Text = request.StepNameLabel;

            if (request.IsHidden)
            {
                HidePanel();
            }
        }

        public void ChangeState(bool isChecked)
        {
            this.step1_chk.Checked = isChecked;
        }

        public void HidePanel()
        {
            this.step1_pnl.Hide();
        }
    }
}
