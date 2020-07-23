using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Models
{
    class PlaygroundHistory
    {
        public List<PlaygroundMemento> History { get; private set; } = new List<PlaygroundMemento>();

        public void SavePlayground(Dictionary<Elements, PlaygroundElement> PlaygroundElements, Time Time, int People, List<Dictionary<Elements, double>> Data)
        {
            this.History.Add(new PlaygroundMemento(PlaygroundElements, Time, People, Data));
        }

        public PlaygroundMemento RestorePlayground(int index)
        {
            if (index < History.Count)
            {
                return History[index];
            }
            throw new Exception("Wrong History index");
        }
    }
}
