using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Models
{
    class Simulator
    {
        private double Step;
        private IFeigned feigned;

        public static event Action<int> HistoryStateCountChanged;

        public Simulator(double step, IFeigned feigned)
        {
            Step = step;
            this.feigned = feigned;
        }

        public (List<Dictionary<Elements, double>>, Dictionary<Elements, History>) SimulateModel()
        {
            for (double i = 0; i <= 17; i += Step) feigned.Simulate(Step);
            HistoryStateCountChanged(feigned.HistoryStateCount);
            return feigned.GetResult();
        }

        public (List<Dictionary<Elements, double>>, Dictionary<Elements, History>) RollbackInTime(int time)
        {
            feigned.RestoreMemento(time);
            return feigned.GetResult();
        }
    }
}
