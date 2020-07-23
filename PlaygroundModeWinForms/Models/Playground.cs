using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Models
{
    class Playground : IInformative, IHavingHistory, IFeigned
    {
        private readonly List<PlaygroundElement> PlaygroundElements = new List<PlaygroundElement>();
        private readonly History History = new History();
        private PlaygroundHistory StateHistory = new PlaygroundHistory();
        private Time Time;
        private int People = 0;

        public Playground(ushort Duration, Dictionary<Elements,  (int, int)> ElementsCounts)
        {
            InitPlaygroundElements(ElementsCounts);
            InitTime(Duration);
        }

        private void InitPlaygroundElements(Dictionary<Elements, (int, int)> elements)
        {
            foreach (var elem in elements)
            {
                switch (elem.Key)
                {
                    case Elements.Slide:
                        for (var i = 0; i < elem.Value.Item2; i++) PlaygroundElements.Add(new Slide(elem.Value.Item1));
                        break;
                    case Elements.Swing:
                        for (var i = 0; i < elem.Value.Item2; i++) PlaygroundElements.Add(new Swing(elem.Value.Item1));
                        break;
                    case Elements.SandBox:
                        for (var i = 0; i < elem.Value.Item2; i++) PlaygroundElements.Add(new SandBox(elem.Value.Item1));
                        break;
                    case Elements.RockingSpring:
                        for (var i = 0; i < elem.Value.Item2; i++) PlaygroundElements.Add(new RockingSpring(elem.Value.Item1));
                        break;
                }
            }
        }

        private void InitTime(ushort Duration)
        {
            Time = new Time(Duration);
        }

        public string GetInfo()
        {
            var text = $"Count of people: {People}, Count of elements: {PlaygroundElements.Count};\n";
            foreach (var element in PlaygroundElements) text += element.GetInfo() + "\n";
            return text;
        }

        public void SaveStateInHistory()
        {
            History.SaveStateInHistory(this);
        }

        private void SaveMementoInHistory() // Save Memento of Playground in StateHistory
        {
            StateHistory.SavePlayground(PlaygroundElements, Time, People);
        }

        private void RestoreMemento(int index) // Restore Memento by index of StateHistory
        {
            if (index >= StateHistory.History.Count)
            {
                return;
            }
            var memento = StateHistory.RestorePlayground(index);
            Time = memento.Time;
            People = memento.People;
            for (int i = 0; i < PlaygroundElements.Count; i++)
            {
                PlaygroundElements[i].RestoreMemento(memento.PlaygroundElementMementos[i]);
            }
        }

        private void RestoreMemento(PlaygroundMemento memento) // Restore Memento by custom memento
        {
            Time = memento.Time;
            People = memento.People;
            for (int i = 0; i < PlaygroundElements.Count; i++)
            {
                PlaygroundElements[i].RestoreMemento(memento.PlaygroundElementMementos[i]);
            }
        }

        public void Simulate(double step)
        {
            Time.TimeNow += step;
            #region Симуляция 1 итерации модели
            ChangePeopleOnPlayground();
            SaveMementoInHistory();
            #endregion
        }

        private void ChangePeopleOnPlayground()
        {
            List<Person> ReservePeople = new List<Person>();
            int PeopleMustBe;
            int RemovablePeople;
            foreach (var elem in PlaygroundElements)
            {
                PeopleMustBe = (int)Math.Round(elem.DistributionFunction(Time.TimeNow));
                if (elem.PeopleOnElementList.Count > PeopleMustBe)
                {
                    for (var i = 0; i < elem.PeopleOnElementList.Count - PeopleMustBe; i++)
                    {
                        RemovablePeople = Globals.Random.Next(0, elem.PeopleOnElementList.Count - 1);
                        ReservePeople.Add(elem.PeopleOnElementList[RemovablePeople]);
                        elem.PeopleOnElementList.RemoveAt(RemovablePeople);
                        People--;
                    }
                }
                else
                {
                    for (var i = 0; i < PeopleMustBe - elem.PeopleOnElementList.Count; i++)
                    {
                        if (elem.Capacity == elem.PeopleOnElementList.Count) continue;
                        if (ReservePeople.Count > 0)
                        {
                            RemovablePeople = Globals.Random.Next(0, ReservePeople.Count - 1);
                            elem.PeopleOnElementList.Add(ReservePeople[RemovablePeople]);
                            ReservePeople.RemoveAt(RemovablePeople);
                        }
                        else
                        {
                            elem.PeopleOnElementList.Add(new Person());
                        }
                        People++;
                    }
                }
            }
        }
    }
}
