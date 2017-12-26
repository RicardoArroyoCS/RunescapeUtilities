using RunescapeUtilities.Shared.Mining;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastFurnaceGuide.Process
{
    public abstract class Process : IProcess
    {
        protected State _state;
        protected List<Step> _steps;

        protected Process()
        {
            _state = new State();
            InitializeSteps();
        }

        protected Process(State state)
        {
            _state = state;
            InitializeSteps();
        }

        public EventHandler ResetControls_event
        {
            get;
            set;
        } = delegate { };

        public EventHandler UpdateControls_event
        {
            get;
            set;
        } = delegate { };

        public List<Step> Steps
        {
            get
            {
                return _steps;
            }
        }

        public int CurrentStepNumber
        {
            get
            {
                int stepNumber = -1;
                if(_state != null)
                {
                    stepNumber = _state.StepNumber;
                }

                return stepNumber;
            }
        }

        #region Abstract Methods
        protected abstract void InitializeSteps();
        #endregion

        #region Protected Methods
        protected void SetCoalCoal(State state)
        {
            state.Inventory = RunescapeUtilities.Shared.Mining.Ore.Coal;
        }

        protected void SetCoalInventoryOre(State state, Ore ore)
        {
            state.Inventory = ore;
        }

        #endregion

        #region Implementation
        public virtual void PerformNextStep()
        {
            int stepNumber = _state.StepNumber;

            if(stepNumber < _steps.Count())
            {
                Step step = _steps[stepNumber];

                _state.Copy(step.ExpectedInventory);
                UpdateControls_event(this, null);

                if(!step.IsRepeatIndefinite)
                {
                    _state.NextStep();
                }
            }
            else
            {
                // Reset
                _state.ResetSteps();
                Ore inventory = _steps.FirstOrDefault().ExpectedInventory;
                _state.Copy(inventory);

                ResetControls_event?.Invoke(this, null);
            }
        }
        #endregion

        public override string ToString()
        {
            return $"State: {_state.ToString()}";
        }
    }
}
