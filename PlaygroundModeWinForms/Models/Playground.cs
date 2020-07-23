using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Models
{
    class Playground : IInformative, IHavingHistory, IFeigned
    {
        private readonly List<PlaygroundElement> PLaygroundElements = new List<PlaygroundElement>();
        private readonly History History = new History();
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
                        for (var i = 0; i < elem.Value.Item2; i++) PLaygroundElements.Add(new Slide(elem.Value.Item1));
                        break;
                    case Elements.Swing:
                        for (var i = 0; i < elem.Value.Item2; i++) PLaygroundElements.Add(new Swing(elem.Value.Item1));
                        break;
                    case Elements.SandBox:
                        for (var i = 0; i < elem.Value.Item2; i++) PLaygroundElements.Add(new SandBox(elem.Value.Item1));
                        break;
                    case Elements.RockingSpring:
                        for (var i = 0; i < elem.Value.Item2; i++) PLaygroundElements.Add(new RockingSpring(elem.Value.Item1));
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
            var text = $"Count of people: {People}, Count of elements: {PLaygroundElements.Count};\n";
            foreach (var element in PLaygroundElements) text += element.GetInfo() + "\n";
            return text;
        }

        public void SaveStateInHistory()
        {
            History.SaveStateInHistory(this);
        }

        public void Simulate(double step)
        {
            Time.TimeNow += step;
            #region Симуляция 1 итерации модели
            ChangePeopleOnPlayground();
            #endregion
        }

        private void ChangePeopleOnPlayground()
        {
            List<Person> ReservePeople = new List<Person>();
            int PeopleMustBe;
            int RemovablePeople;
            foreach (var elem in PLaygroundElements)
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
