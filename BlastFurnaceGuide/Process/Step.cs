using RunescapeUtilities.Shared.Mining;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastFurnaceGuide.Process
{
    public class Step
    {
        public Step(int stepNumber, Ore inventory, Ore coalBag = Ore.Coal, bool isRepeatIndefinite = false)
        {
            StepNumber = stepNumber;
            ExpectedCoalBag = coalBag;
            ExpectedInventory = inventory;
            IsRepeatIndefinite = isRepeatIndefinite;
        }

        public Ore ExpectedCoalBag
        {
            get;
        }

        public Ore ExpectedInventory
        {
            get;
        }

        public bool IsRepeatIndefinite
        {
            get;
        }

        public int StepNumber
        {
            get;
        }
    }
}
