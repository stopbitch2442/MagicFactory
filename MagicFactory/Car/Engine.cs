namespace MagicFactory.Car
{
    public abstract class Engine
    {
        public int Power;
        public int Speed;

        public event EventHandler EventChangeSpeed;

        public void EventChangeSpeedExecutor()
        {
            OnEventChangeSpeed();
        }

        protected virtual void OnEventChangeSpeed()
        {
            EventChangeSpeed?.Invoke(this, EventArgs.Empty);
        }
        public void TurnOn()
        {
            Console.WriteLine("завёвся движок");
        }

        public void TurnOff()
        {
            Console.WriteLine("заглох движок");
        }


        public void ChangeDumperPosition(int degress)
        {
            Speed = degress / 180 * 200;
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
