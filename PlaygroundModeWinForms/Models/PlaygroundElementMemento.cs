using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Models
{
    class PlaygroundElementMemento
    {
        public bool Free { get; protected set; }
        public int PeopleOnElement { get; private set; }
        public History History { get; private set; }

        public PlaygroundElementMemento(PlaygroundElement playgroundElement)
        {
            Free = playgroundElement.Free;
            PeopleOnElement = playgroundElement.PeopleOnElement;
            History = playgroundElement.History;
        }
    }
}
