using MagicFactory.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicFactory.Helicopter
{
    public class Helicopter : Transport
    {
        private Pedals[] pedals;    // Direction control pedals, Rotor speed control pedals, Clutch pedals
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
    }
}
