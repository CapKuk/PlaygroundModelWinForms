using PlaygroundModeWinForms.Models;
using PlaygroundModeWinForms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaygroundModeWinForms.Presenters
{
    class ModelPresenter : IPresenter
    {
        private Simulator Simulator;
        public static event Action<(List<Dictionary<Elements, double>>, Dictionary<Elements, History>)> DataChanged;
        public static event Action<int> CountChanged;

        public ModelPresenter()
        {
            ModelForm.MoveButtonDown += ChangeModel;
            ModelForm.StartSimulator += StartSimulator;
        }

        private (List<Dictionary<Elements, double>>, Dictionary<Elements, History>) RollbackInTime(int Time)
        {
            return Simulator.RollbackInTime(Time);
        }

        public void Run()
        {
            var form = new ModelForm();
            form.ShowDialog();
        }

        private void StartSimulator()
        {
            Simulator = new Simulator(0.1, new Playground());
            Simulator.HistoryStateCountChanged += CountChange;
            DataChanged(Simulator.SimulateModel());
        }

        private void ChangeModel(int TimeNow)
        {
            DataChanged(RollbackInTime(TimeNow));
        }

        private void CountChange(int count)
        {
            CountChanged(count);
        }
    }
}
