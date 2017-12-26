using BlastFurnaceGuide.Controls;
using BlastFurnaceGuide.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastFurnaceGuide.Guides
{
    public class MithrilBarsGuide : Guide
    {
        public MithrilBarsGuide(BlastFurnacePanelControl panelControl) 
            :base(panelControl)
        {
            Process = new MithrilBarsProcess();
            base.Initialize();
            panelControl.GuideName = "Mithril Bars Guide";
        }
    }
}
