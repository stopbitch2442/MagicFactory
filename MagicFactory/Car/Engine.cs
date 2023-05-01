using static MagicFactory.Car.Engine;


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
        public abstract class CarEngine : Engine
        {
            public double Speed;
            public int ChangeDumperPosition(double degress)
            {
                return (int)(Speed = degress / 180 * 200);
            }
            public abstract class ElectricEngine : CarEngine
            {
                public int Voltage;

                public class TeslaEngine : ElectricEngine
                {
                    
                }
            }

            public abstract class InternalCombustionEngine : CarEngine
            {
                public int Volume;

                public class VazEngine : InternalCombustionEngine
                {

                }
            }
        }

        public abstract class HelicopterEngine : Engine
        {
            public int Volume;
            public int Speed;

            public class BoeingEngine : HelicopterEngine
            {
                public int SpeedRotation(int speed, int volume)
                {
                    speed = this.Speed;
                    volume = this.Volume;
                    int engineSpeed = speed * volume * 3;
                    return engineSpeed;
                }
            }
        }
    }

}
