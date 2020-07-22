using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Models
{
    class Simulator
    {
        public static void SimulateOneTimeSlot(IFeigned feigned)
        {
            feigned.Simulate();
        }
    }
}
