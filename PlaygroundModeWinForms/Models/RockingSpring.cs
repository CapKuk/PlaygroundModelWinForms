using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Models
{
    class RockingSpring : PlaygroundElement
    {
        public RockingSpring(int capacity = 1) : base(capacity)
        {
            Name = "Качалка на пружине";
        }

        public override double DistributionFunction(double x)
        {
            if (x >= 0 && x < 3)
            {
                return 2.2 * Math.Pow(Math.E, (-0.9 * x + 0.9)) - 0.2;
            }
            else if (x >= 3 && x < 11.5)
            {
                return Math.Pow(Math.E, (-Math.Pow((x - 10), 2) / (2 * 0.17))) / (0.28 * 2 * Math.Sqrt(Math.PI));
            }
            else if (x >= 11.5 && x < 17)
            {
                return Math.Pow(Math.E, (-Math.Pow((x - 13), 2) / (2 * 0.17))) / (0.28 * 2 * Math.Sqrt(Math.PI));
            }
            return -1;
        }

        public override string GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
