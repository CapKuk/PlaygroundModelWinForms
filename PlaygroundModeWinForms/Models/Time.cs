using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Models
{
    class Time
    {
        public Time(uint duration)
        {
            Duration = duration;
        }

        public uint TimeNow { get; set; }
        public uint Duration { get; private set; }
    }
}
