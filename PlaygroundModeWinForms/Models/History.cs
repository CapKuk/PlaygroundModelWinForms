using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Models
{
    class History
    {
        public History(History history)
        {
            HistoryList = new List<string>(history.HistoryList);
        }
        public History() { }

        public List<string> HistoryList { get; private set; } = new List<string>();

        public void SaveStateInHistory(IInformative informative)
        {
            HistoryList.Add(informative.GetInfo());
        }
    }
}
