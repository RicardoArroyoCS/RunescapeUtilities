using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastFurnaceGuide.Process
{
    public interface IProcess
    {
        //void BeginProcess();
        void PerformNextStep();

        List<Step> Steps { get; }
        int CurrentStepNumber { get; }
        EventHandler ResetControls_event { get; set; }
        EventHandler UpdateControls_event { get; set; }
    }
}
