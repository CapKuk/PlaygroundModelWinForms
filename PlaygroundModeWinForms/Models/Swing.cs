using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Models
{
    class Swing : PlaygroundElement
    {
        public override double DistributionFunction(double x)
        {
            if (x >= 0 && x < 2)
            {
                return 2 * Math.Pow(Math.E, (-0.8 * x + 1.1)) - 0.2;
            }
            else if (x >= 2 && x < 4)
            {
                return -0.2 * Math.Pow(Math.E, (x - 3)) + 1.1;
            }
            else if (x >= 4 && x < 7.5)
            {
                return Math.Pow(Math.E, (-Math.Pow((x - 5.5), 2) / 2 * 1.5 * 1.5)) / (0.15 * Math.Sqrt(2 * Math.PI));
            }
            else if (x >= 7.5 && x < 11)
            {
                return Math.Pow(Math.E, (-Math.Pow((x - 9.5), 2) / 2 * 1.5 * 1.5)) / (0.15 * Math.Sqrt(2 * Math.PI));
            }
            else if (x >= 11 && x < 13)
            {
                return Math.Pow(Math.E, (-Math.Pow((x - 12), 2) / 2 * 1.6 * 1.6)) / (0.2 * Math.Sqrt(2 * Math.PI));
            }
            else if (x >= 13 && x < 17)
            {
                return 1 - 3 * Math.Pow(Math.E, (-3 * (-x + 17.4)));
            }
            return -1;
        }

        public override string GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
