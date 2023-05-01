using MagicFactory.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicFactory.Helicopter
{
    public abstract class Helicopter : Transport
    {
        private Pedals[] pedals;   
        private Suspention suspention;
        private Engine engine;
        private Propeller[] propeller;
        private int maxHeightInSpase;
        public Helicopter(Pedals[] pedals, Suspention suspention, Engine engine, Propeller[] propeller, int heightInSpase)
        {
            this.pedals = pedals;
            this.suspention = suspention;
            this.engine = engine;
            this.propeller = propeller;
            this.maxHeightInSpase = heightInSpase;
        }

        public string StartsUp()
        {
            if (maxHeightInSpase > 0)
            {
                return "БЖЖЖЖ вертолётик взлетает";
            }
            else
            {
                return "Вертолётик ещё не оторвался от земли";
            }
        }
        public string Stop()
        {
            return "Наш вертолёт остановился";
        }

        public class Boeing : Helicopter
        {
            public Boeing(Pedals[] pedals, Suspention suspention, Engine engine, Propeller[] propeller, int heightInSpase) : base(pedals, suspention, engine, propeller, heightInSpase)
            {

            }
        }
    }
}
