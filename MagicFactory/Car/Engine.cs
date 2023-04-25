using static MagicFactory.Car.Engine;
using static MagicFactory.Car.Engine.ElectricEngine;
using static MagicFactory.Car.Engine.InternalCombustionEngine;

namespace MagicFactory.Car
{
    
    public abstract class Engine
    {
        
        public int Power;
        public double Speed;
        
        public event EventHandler EventChangeSpeed;

        public void EventChangeSpeedExecutor()
        {
            OnEventChangeSpeed();
        }

        protected virtual void OnEventChangeSpeed()
        {
            EventChangeSpeed?.Invoke(this, EventArgs.Empty);
        }
        public string TurnOn()
        {
            return "завёвся движок";
        }

        public string TurnOff()
        {
            return "заглох движок";
        }

        public int ChangeDumperPosition(double degress)
        {
            return (int)(Speed = degress / 180 * 200);
        }
        public abstract class ElectricEngine : Engine
        {
            public int Voltage;

            public class TeslaEngine : ElectricEngine
            {

            }
        }



        public abstract class InternalCombustionEngine : Engine
        {
            public int Volume;

            public class VazEngine : InternalCombustionEngine
            {

            }
        }
    }

}
