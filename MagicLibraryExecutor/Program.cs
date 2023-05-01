using MagicFactory.Car;
using MagicFactory.Helicopter;
using static MagicFactory.Car.Car;
using static MagicFactory.Car.Engine;
using static MagicFactory.Car.Engine.HelicopterEngine;
using static MagicFactory.Car.Suspention;
using static MagicFactory.Helicopter.Helicopter;
using static MagicFactory.Helicopter.Suspention;

namespace MagicLibraryExecutor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // TestCar();
            TestHelicopter();
        }

        public static void TestCar()
        {

            CarEngine.ElectricEngine.TeslaEngine teslaEngine = new CarEngine.ElectricEngine.TeslaEngine();
            Console.WriteLine("Тестируем двигатель теслы: " + teslaEngine.TurnOn() + " Скорость при педали газа на 100 градусов = " + teslaEngine.ChangeDumperPosition(100));

            CarEngine.InternalCombustionEngine.VazEngine vazEngine = new CarEngine.InternalCombustionEngine.VazEngine();
            Console.WriteLine("Тестируем двигатель VAZ: " + vazEngine.TurnOn() + " Скорость при педали газа на 100 градусов = " + vazEngine.ChangeDumperPosition(100));

            Tesla tesla = new Tesla(new MagicFactory.Car.Pedals[] { new GasPedal(), new BrakePedal() }, new TeslaSuspention(), new CarEngine.ElectricEngine.TeslaEngine(), "Р131ТЕ40");
            Console.WriteLine(tesla.StartsUp());
            Console.WriteLine(tesla.ToString());
        }

        public static void TestHelicopter()
        {
            HelicopterEngine.BoeingEngine boeingEngine = new BoeingEngine();
            Console.WriteLine("Тестируем двигатель боинга: " + boeingEngine.TurnOn());

            Boeing boeing = new Boeing(new MagicFactory.Helicopter.Pedals[] { new ControlPedal(), new RotorSpeedPedal() }, new BoeingSuspention(), new BoeingEngine(), new Propeller[] { new MainPropeller(), new TailPropeller()}, 1);
            Console.WriteLine(boeing.StartsUp());
        }

    }
}