using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Models
{
    class SandBox : PlaygroundElement
    {
        public override double DistributionFunction(double x)
        {
            if (x >= 0 && x < 5.5)
            {
                return Math.Pow(Math.E, (-Math.Pow((x - 3), 2) * 2)) / (0.4 * Math.Sqrt(2 * Math.PI));
            }
            else if (x >= 5.5 && x < 10.5)
            {
                return Math.Pow(Math.E, (-Math.Pow((x - 8.5), 2) / 2 * 1.5 * 1.5)) / (0.3 * Math.Sqrt(2 * Math.PI));
            }
            else if (x >= 10.5 && x < 13)
            {
                return Math.Pow(Math.E, (-Math.Pow((x - 12), 2) * 2)) / (0.4 * Math.Sqrt(2 * Math.PI));
            }
            else if (x >= 13 && x < 17)
            {
                return Math.Pow(Math.E, (-Math.Pow((x - 14.5), 2) / 2 * 1.5 * 1.5)) / (0.3 * Math.Sqrt(2 * Math.PI));
            }
            return -1;
        }

        public override string GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
