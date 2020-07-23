using PlaygroundModeWinForms.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Models
{
    interface IFeigned : IMemento
    {
        int HistoryStateCount { get; set; }
        void Simulate(double step);
        (List<Dictionary<Elements, double>>, Dictionary<Elements, History>) GetResult();
    }
}
