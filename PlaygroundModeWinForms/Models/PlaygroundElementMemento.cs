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
        public List<Person> PeopleOnElementList { get; private set; }

        public PlaygroundElementMemento(PlaygroundElement playgroundElement)
        {
            Free = playgroundElement.Free;
            PeopleOnElementList = playgroundElement.PeopleOnElementList;
        }
    }
}
