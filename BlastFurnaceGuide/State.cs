using RunescapeUtilities.Shared.Mining;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastFurnaceGuide
{
    public class State
    {
        public State()
        {
        }

        public State(State state)
        {
            Inventory = state.Inventory;
        }

        public Ore CoalBag
        {
            get
            {
                return Ore.Coal;
            }
        }

        public Ore Inventory
        {
            get;
            set;
        }

        public int StepNumber
        {
            get;
            private set;
        } = 0;

        public bool IsDoubleCoal
        {
            get
            {
                return CoalBag == Ore.Coal && Inventory == Ore.Coal;
            }
        }

        public void Copy(Ore inventory, Ore coalBag = Ore.Coal)
        {
            Inventory = inventory;
        }

        public void NextStep()
        {
            StepNumber++;
        }

       public void ResetSteps()
        {
            StepNumber = 0;
        }

        public override string ToString()
        {
            return $"CoalBag: \"{CoalBag}\" Inventory: \"{Inventory}\"";
        }
    }
}
