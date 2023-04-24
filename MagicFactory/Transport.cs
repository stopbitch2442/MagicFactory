using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MagicFactory.Engine;

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
            foreach (var wheel in wheels) 
            { 
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
        
    }

    public class BrakePedal : Pedals
    {
        
    }

    

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
