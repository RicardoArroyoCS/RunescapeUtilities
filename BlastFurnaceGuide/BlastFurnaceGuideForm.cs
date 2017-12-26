using BlastFurnaceGuide.Guides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlastFurnaceGuide
{
    public partial class BlastFurnaceGuideForm : Form
    {
        IGuide _currentGuide;
        public static EventHandler<KeyEventArgs> KeyPress_handler = null;
        public static object _lockObj = new object();

        public BlastFurnaceGuideForm()
        {
            InitializeComponent();
            InitiateDefaultGuide();
        }

        public static EventHandler<KeyEventArgs> KeyPressHandler
        {
            get
            {
                return KeyPress_handler;
            }
            set
            {
                lock (_lockObj)
                {
                    KeyPress_handler = value;
                }
            }
        }

        private void InitiateDefaultGuide()
        {
            _currentGuide = new SteelBarsGuide(this.steelGuidePanelControl_control);
        }

        private void blastFurnace_tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            // New Tab Clicked
            if (sender is TabControl tabControl)
            {
                switch (tabControl.SelectedIndex)
                {
                    case 0:
                        _currentGuide = new SteelBarsGuide(this.steelGuidePanelControl_control);
                        break;
                    case 1:
                        _currentGuide = new MithrilBarsGuide(this.mithrilGuidePanelControl_control);
                        break;
                }
            }
        }

        //private void BlastFurnaceGuideForm_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    KeyPressHandler?.Invoke(this, e);
        //}

        private void BlastFurnaceGuideForm_KeyDown(object sender, KeyEventArgs e)
        {
            KeyPressHandler?.Invoke(this, e);
        }
    }
}
