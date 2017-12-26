using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastFurnaceGuide.Process
{
    public class SteelBarsProcess : Process, IProcess
    {
        public SteelBarsProcess()
            : base()
        {
        }
        public SteelBarsProcess(State state)
            :base(state)
        {
        }

        protected override void InitializeSteps()
        {
            _steps = new List<Step>()
            {
                new Step(0, RunescapeUtilities.Shared.Mining.Ore.Coal),
                new Step(1, RunescapeUtilities.Shared.Mining.Ore.Iron, isRepeatIndefinite: true),
            };
        }  
    }
}
