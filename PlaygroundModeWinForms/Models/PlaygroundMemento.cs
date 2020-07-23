using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Models
{
    class PlaygroundMemento
    {
        public Dictionary<Elements, PlaygroundElementMemento> PlaygroundElementMementos { get; private set; } = new Dictionary<Elements, PlaygroundElementMemento>();
        public Time Time { get; private set; }
        public int People { get; private set; }
        public Dictionary<Elements, History> History = new Dictionary<Elements, History>();
        public List<Dictionary<Elements, double>> Data = new List<Dictionary<Elements, double>>();

        public PlaygroundMemento(Dictionary<Elements, PlaygroundElement> playgroundElements, Time time, int people, List<Dictionary<Elements, double>> data)
        {
            Time = time;
            People = people;
            foreach (var playgoundElement in playgroundElements)
            {
                PlaygroundElementMementos.Add(playgoundElement.Key ,new PlaygroundElementMemento(playgoundElement.Value));
            }
            CopyData(data);
            SaveHistory();
        }

        private void CopyData(List<Dictionary<Elements, double>> data)
        {
            foreach (var i in data)
            {
                var d = new Dictionary<Elements, double>(i);
                Data.Add(d);
            }
        }

        private void SaveHistory()
        {
            foreach (var i in PlaygroundElementMementos)
            {
                History.Add(i.Key, new History(i.Value.History));
            }
        }
    }
}
