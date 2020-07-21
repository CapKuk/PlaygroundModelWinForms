using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Models
{
    class Playground : IInformative, IHavingHistory
    {
        private Dictionary<PlaygroundElement, int> PLaygroundElements = new Dictionary<PlaygroundElement, int>(); // Pair (Element, count)
        private readonly History History = new History();

        public string GetInfo()
        {
            throw new NotImplementedException();
        }

        public void SaveStateInHistory()
        {
            History.SaveStateInHistory(this);
        }
    }
}
