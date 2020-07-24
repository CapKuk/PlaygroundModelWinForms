using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Models
{
    class Playground : IInformative, IHavingHistory, IFeigned
    {
        private Dictionary<Elements, PlaygroundElement> PlaygroundElements = new Dictionary<Elements, PlaygroundElement>();
        private Dictionary<Elements, History> History = new Dictionary<Elements, History>();
        private PlaygroundHistory StateHistory = new PlaygroundHistory();
        private Time Time;
        private int People = 0;
        private List<Dictionary<Elements, double>> Data = new List<Dictionary<Elements, double>>();
        public int HistoryStateCount { get; set; } = 0;

        public Playground()
        {
            InitPlaygroundElements();
            InitTime();
            InitHistory();
        }

        private void InitPlaygroundElements()
        {
            PlaygroundElements.Add(Elements.Swing, new Swing(2));
            PlaygroundElements.Add(Elements.Slide, new Slide(1));
            PlaygroundElements.Add(Elements.SandBox, new SandBox(1));
            PlaygroundElements.Add(Elements.RockingSpring, new RockingSpring(1));
        }

        private void InitHistory()
        {
            foreach (var elem in PlaygroundElements) History.Add(elem.Key, elem.Value.History);
        }

        private void InitTime()
        {
            Time = new Time(17);
        }

        public void SaveStateInHistory()
        {
            foreach (var elem in PlaygroundElements) elem.Value.SaveStateInHistory();
        }

        private void SaveMementoInHistory() // Save Memento of Playground in StateHistory
        {
            StateHistory.SavePlayground(PlaygroundElements, Time, People, Data);
        }

        public void RestoreMemento(int index) // Restore Memento by index of StateHistory
        {
            if (index >= StateHistory.History.Count)
            {
                return;
            }
            var memento = StateHistory.RestorePlayground(index);
            Time = memento.Time;
            People = memento.People;
            Data = memento.Data;
            History = memento.History;
            foreach (var i in PlaygroundElements)
            {
                i.Value.RestoreMemento(memento.PlaygroundElementMementos[i.Key]);
            }
        }

        private void RestoreMemento(PlaygroundMemento memento) // Restore Memento by custom memento
        {
            Time = memento.Time;
            People = memento.People;
            foreach (var i in PlaygroundElements)
            {
                i.Value.RestoreMemento(memento.PlaygroundElementMementos[i.Key]);
            }
        }

        public void Simulate(double step)
        {
            #region Симуляция 1 итерации модели
            ChangePeopleOnPlayground();

            var data = new Dictionary<Elements, double>();
            data.Add(Elements.Time, Time.TimeNow);
            data.Add(Elements.Slide, PlaygroundElements[Elements.Slide].PeopleOnElement);
            data.Add(Elements.Swing, PlaygroundElements[Elements.Swing].PeopleOnElement);
            data.Add(Elements.SandBox, PlaygroundElements[Elements.SandBox].PeopleOnElement);
            data.Add(Elements.RockingSpring, PlaygroundElements[Elements.RockingSpring].PeopleOnElement);
            Data.Add(data);

            SaveStateInHistory();

            SaveMementoInHistory();
            ChangeHistoryStateCount();
            #endregion
            Time.TimeNow += step;
        }

        private void ChangePeopleOnPlayground()
        {
            double PeopleMustBe;
            int newPeople;
            foreach (var elem in PlaygroundElements)
            {
                PeopleMustBe = elem.Value.DistributionFunction(Time.TimeNow) + 0.5;

                if (elem.Value.PeopleOnElement == (int)Math.Round(PeopleMustBe + 0.5)) continue;

                newPeople = Globals.Random.Next(0, (int)Math.Round(PeopleMustBe));
                if (elem.Value.Capacity < newPeople) continue;
                People -= elem.Value.PeopleOnElement - newPeople;
                elem.Value.PeopleOnElement = newPeople;
            }
        }

        public string GetInfo()
        {
            return $"Count of people: {People}, Count of elements: {PlaygroundElements.Count};\n";
        }

        public (List<Dictionary<Elements, double>>, Dictionary<Elements, History>) GetResult()
        {
            return (Data, History);
        }

        private void ChangeHistoryStateCount()
        {
            HistoryStateCount = StateHistory.History.Count;
        } 
    }
}
