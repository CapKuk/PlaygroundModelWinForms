using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Models
{
    class Slide : PlaygroundElement
    {
        public Slide(int capacity = 1) : base(capacity)
        {
            Name = "Горка";
        }

        public override double DistributionFunction(double x)
        {
            if (x >= 0 && x < 2)
            {
                return 1.1 * Math.Pow(Math.E, (-2 * x + 2)) - 0.1;
            }
            else if (x >= 2 && x < 9.5)
            {
                return Math.Pow(Math.E, (-Math.Pow((x - 7), 2) / (2 * 0.2))) / (0.28 * 2 * Math.Sqrt(Math.PI));
            }
            else if (x >= 9.5 && x < 17)
            {
                return Math.Pow(Math.E, (-Math.Pow((x - 12.5), 2) / (2 * 0.5))) / (0.25 * 2 * Math.Sqrt(Math.PI));
            }
            return -1;
        }
    }
}
