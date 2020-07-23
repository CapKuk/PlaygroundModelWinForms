using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaygroundModeWinForms.Presenters
{
    class StartPresenter : IPresenter
    {

        public static event Action ModelStart;

        public StartPresenter()
        {
            MakeBindings();
        }

        private void MakeBindings()
        {
            Start.StartButtonDown += StartAndRedirection;
        }

        private void StartAndRedirection()
        {
            ModelStart();
        }

        public void Run()
        {
            Application.Run(new Start());
        }
    }
}
