using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Models
{
    class Time
    {
        public Time(ushort duration)
        {
            Duration = duration;
        }

        public double TimeNow { get; set; } = 0;
        public ushort Duration { get; private set; }
    }
}
