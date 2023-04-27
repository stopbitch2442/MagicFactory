namespace MagicFactory.Car
{
    public abstract class Suspention
    {
        public int Speed;
        public Wheels[] wheels;

        public class Wheels
        {
            public int Size;
            public int Speed;
        }

        public class TeslaSuspention : Suspention
        {

        }

        public void ChangeSpeed(int speed)
        {
            Speed = speed;
            foreach (var wheel in wheels)
            {
                wheel.Speed = speed / 4;
            }
        }

    }
}
