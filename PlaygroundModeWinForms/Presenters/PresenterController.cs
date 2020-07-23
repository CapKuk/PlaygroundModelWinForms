using PlaygroundModeWinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Presenters
{
    class PresenterController : IPresenter
    {
        public StartPresenter StartPresenter = new StartPresenter();
        public ModelPresenter ModelPresenter = new ModelPresenter();

        public PresenterController()
        {
            MakeBindings();
        }

        private void MakeBindings()
        {
            StartPresenter.ModelStart += StartSimulator;
        }

        private void StartSimulator()
        {
            RunModelPresenter();
        }

        public void Run()
        {
            StartPresenter.Run();
        }

        private void RunModelPresenter()
        {
            ModelPresenter.Run();
        }
    }
}
