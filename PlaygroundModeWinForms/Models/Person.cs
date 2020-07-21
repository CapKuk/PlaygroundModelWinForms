using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Models
{
    class Person : IInformative, IRandomlyDistributed
    {
        public string GetInfo()
        {
            throw new NotImplementedException();
        }

        public double DistributionFunction(double x)
        {
            if (x >= 0 && x < 2)
            {
                return 5.5 * Math.Pow(Math.E, (-0.9 * x + 0.9)) - 0.2;
            }
            else if (x >= 2 && x < 4)
            {
                return -Math.Pow(Math.E, (x - 3)) + 2.5;
            }
            else if (x >= 4 && x < 7)
            {
                return Math.Pow(Math.E, (-Math.Pow((x - 5.65), 2) / (2 * 0.7))) / (0.12 * 2 * Math.Sqrt(Math.PI));
            }
            else if (x >= 7 && x < 11)
            {
                return Math.Pow(Math.E, (-Math.Pow(x - 9.2, 2) / (2 * 0.35))) / (0.14 * 2 * Math.Sqrt(Math.PI)) + 1;
            }
            else if (x >= 11 && x < 17)
            {
                return Math.Pow(Math.E, (-Math.Pow(x - 13.2, 2) / (2 * 2.3))) / (0.082 * 2 * Math.Sqrt(Math.PI));
            }
            return -1;
        }
    }
}
