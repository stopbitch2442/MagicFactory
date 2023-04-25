namespace MagicFactory.Car
{
    public abstract class Car : Transport
    {
        private Pedals[] pedals;
        private Suspention suspention;
        private Engine engine;
        private string RegistrationNumber;

        public virtual void StartsUp()
        {

        }
        public void Stop()
        {

        }

        public void SubscribeToGasPedal(GasPedal gasPedal)
        {
            gasPedal.EventPress += GasPedal_EventPress;
        }

        public void GasPedal_EventPress(object sender, EventArgs e)
        {
            engine.ChangeDumperPosition(10);
        }

        public void SubscribeToEngine(Engine engine)
        {
            engine.EventChangeSpeed += Engine_EventChangeSpeed;
        }

        public void Engine_EventChangeSpeed(object sender, EventArgs e)
        {
            suspention.ChangeSpeed(suspention.Speed);
        }

    }
}
