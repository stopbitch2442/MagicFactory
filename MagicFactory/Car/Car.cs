

namespace MagicFactory.Car
{
    public abstract class Car : Transport
    {
        private Pedals[] pedals;
        private Suspention suspention;
        private Engine engine;
        private string RegistrationNumber;

        public Car(Pedals[] pedals, Suspention suspention, Engine engine, string registrationNumber)
        {
            this.pedals = pedals;
            this.suspention = suspention;
            this.engine = engine;
            this.RegistrationNumber = registrationNumber;

            GasPedal gasPedal = new GasPedal();
            gasPedal.EventPress += GasPedal_EventPress;
            engine.EventChangeSpeed += Engine_EventChangeSpeed;
        }

        public class Tesla : Car
        {
            public Tesla(Pedals[] pedals, Suspention suspention, Engine engine, string registrationNumber) : base(pedals, suspention, engine, registrationNumber)
            {
            }

            public override string ToString()
            {
                string pedalsInfo = "";
                foreach (var pedal in this.pedals)
                {
                    pedalsInfo += pedal.GetType().Name + " ";
                }

                return "Tesla information:\n" +
                "Pedals: " + pedalsInfo + "\n" +
                "Suspension: " + this.suspention.GetType().Name + "\n" +
                "Engine: " + this.engine.GetType().Name + "\n" +
                "RegistrationNumber: " + this.RegistrationNumber;
            }

        }

        public string StartsUp()
        {
            return "тесла тронулась и помчалась";
        }
        public void Stop()
        {

        }

        public void GasPedal_EventPress(object sender, EventArgs e)
        {
            Engine.CarEngine.ElectricEngine.TeslaEngine engine = new Engine.CarEngine.ElectricEngine.TeslaEngine();
            engine.ChangeDumperPosition(10);
        }
       
        public void Engine_EventChangeSpeed(object sender, EventArgs e)
        {
            suspention.ChangeSpeed(suspention.Speed);
        }

    }

   
}
