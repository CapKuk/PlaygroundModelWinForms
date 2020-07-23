using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Models
{
    abstract class PlaygroundElement : IInformative, IHavingHistory, IRandomlyDistributed
    {
        public string Name { get; protected set; } // Качеля, горка и т.п.
        public int Capacity { get; protected set; } // Сколько человек может находиться на элементе одновременно
        public bool Free { get; protected set; } = true; // true - есть свободное место, false - нет
        public History History { get; private set; } = new History();

        protected PlaygroundElement(int capacity = 1)
        {
            Capacity = capacity;
        }

        public int PeopleOnElement = 0;

        public void SaveStateInHistory()
        {
            History.SaveStateInHistory(this);
        }

        public void RestoreMemento(PlaygroundElementMemento memento)
        {
            Free = memento.Free;
            PeopleOnElement = memento.PeopleOnElement;
            this.History = History;
        }

        public string GetInfo() // Для получния информации об объекте для пользователя
        {
            Free = Capacity > PeopleOnElement;
            var text = $"Name: {Name}, Capacity: {PeopleOnElement}/{Capacity}, ";
            if (Free)
            {
                text += "Free;\n";
            }
            else
            {
                text += "Busy;\n";
            }
            return text;
        }
        public abstract double DistributionFunction(double x);
    }
}
