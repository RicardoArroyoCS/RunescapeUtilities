using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastFurnaceGuide.Process
{
    public class MithrilBarsProcess: Process, IProcess
    {
        public MithrilBarsProcess()
            :base()
        {

        }
        public MithrilBarsProcess(State state)
            :base(state)
        {
        }

        protected override void InitializeSteps()
        {
            _steps = new List<Step>()
            {
                new Step(0, RunescapeUtilities.Shared.Mining.Ore.Coal),
                new Step(1, RunescapeUtilities.Shared.Mining.Ore.Mithril),
                new Step(2, RunescapeUtilities.Shared.Mining.Ore.Mithril),
            };
        }
    }
}
