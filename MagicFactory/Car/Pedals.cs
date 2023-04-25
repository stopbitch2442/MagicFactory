namespace MagicFactory.Car
{
    public abstract class Pedals
    {
        public string Name;
        public event EventHandler EventPress;

        public void EventPressExecutor()
        {
            OnEventPress();
        }

        protected virtual void OnEventPress()
        {
            EventPress?.Invoke(this, EventArgs.Empty);
        }

    }

    public class GasPedal : Pedals
    {

    }

    public class BrakePedal : Pedals
    {

    }

}
