using BlastFurnaceGuide.Controls;
using BlastFurnaceGuide.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastFurnaceGuide.Guides
{
    public class SteelBarsGuide: Guide
    {
        public SteelBarsGuide(BlastFurnacePanelControl panelControl)
            :base(panelControl)
        {
            Process = new SteelBarsProcess();
            base.Initialize();
            panelControl.GuideName = "Steel Bars Guide";
        }

        public override string ToString()
        {
            return Process.ToString();
        }

    }
}
