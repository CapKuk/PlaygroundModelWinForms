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

        public Playground(ushort Duration, Dictionary<Elements, int> ElementsCounts)
        {
            InitPlaygroundElements(ElementsCounts);
            InitTime(Duration);
        }

        private void InitPlaygroundElements(Dictionary<Elements, int> elements)
        {
            foreach (var elem in elements)
            {
                switch (elem.Key)
                {
                    case Elements.Slide:
                        for (var i = 0; i < elem.Value; i++) PLaygroundElements.Add(new Slide());
                        break;
                    case Elements.Swing:
                        for (var i = 0; i < elem.Value; i++) PLaygroundElements.Add(new Swing());
                        break;
                    case Elements.SandBox:
                        for (var i = 0; i < elem.Value; i++) PLaygroundElements.Add(new SandBox());
                        break;
                    case Elements.RockingSpring:
                        for (var i = 0; i < elem.Value; i++) PLaygroundElements.Add(new RockingSpring());
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
            throw new NotImplementedException();
        }

        public void SaveStateInHistory()
        {
            History.SaveStateInHistory(this);
        }

        public void Simulate(double step)
        {
            Time.TimeNow += step;
            // симуляция 1 итерации модели
        }
    }
}
