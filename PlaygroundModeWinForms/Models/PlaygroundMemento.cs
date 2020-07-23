using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Models
{
    class PlaygroundMemento
    {
        public List<PlaygroundElementMemento> PlaygroundElementMementos { get; private set; }
        public Time Time { get; private set; }
        public int People { get; private set; }

        public PlaygroundMemento(List<PlaygroundElement> playgroundElements, Time time, int people)
        {
            Time = time;
            People = people;
            foreach (var playgoundElement in playgroundElements)
            {
                PlaygroundElementMementos.Add(new PlaygroundElementMemento(playgoundElement));
            }
        }
    }
}
