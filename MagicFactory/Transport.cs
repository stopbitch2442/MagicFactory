using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicFactory
{
    public abstract class Transport
    {
        public void Move()
        {

        }

        public void Brake()
        {

        }
    }
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

        }

        public void TurnOff()
        {

        }
        
        
        public void ChangeDumperPosition(int degress)
        { 
            Speed = degress / 180 * 200;
        }
        abstract class ElectricEngine
        {
            public int Voltage;
        }
        abstract class InternalCombustionEngine
        {
            public int Volume;
        }
    }

    public abstract class Suspention
    {
        public int Speed;
        public Wheels[] wheels;

        public class Wheels
        {
            public int Size;
            public int Speed;
        }
            
        public void ChangeSpeed(int speed)
        {
            Speed= speed;
            foreach (var wheel in wheels) { 
            wheel.Speed = speed / 4;
            }
        }

    }

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
        // Реализация педали газа
    }

    public class BrakePedal : Pedals
    {
        // Реализация педали тормоза
    }

    

    public abstract class Car : Transport
    {
        private Pedals[] pedals;
        private Suspention suspention;
        private Engine engine;
        private string RegistrationNumber;

        private void StartsUp()
        {

        }
        private void Stop()
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
