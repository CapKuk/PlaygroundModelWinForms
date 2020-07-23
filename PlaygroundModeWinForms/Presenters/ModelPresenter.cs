using PlaygroundModeWinForms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Presenters
{
    class ModelPresenter : IPresenter
    {
        public ModelPresenter()
        {
        }

        public void Run()
        {
            new ModelForm().ShowDialog();
        }
    }
}
