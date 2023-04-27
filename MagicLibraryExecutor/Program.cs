using MagicFactory.Car;
using static MagicFactory.Car.Car;
using static MagicFactory.Car.Engine;
using static MagicFactory.Car.Engine.ElectricEngine;
using static MagicFactory.Car.Engine.InternalCombustionEngine;
using static MagicFactory.Car.Suspention;

namespace MagicLibraryExecutor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TestEngine();

        }

        public static void TestEngine()
        {
            
            TeslaEngine teslaEngine = new TeslaEngine();
            Console.WriteLine("Тестируем теслу: " + teslaEngine.TurnOn() + " Скорость при педали газа на 100 градусов = " + teslaEngine.ChangeDumperPosition(100));
            
            VazEngine vazEngine = new VazEngine();
            Console.WriteLine("Тестируем VAZ: " + vazEngine.TurnOn() + " Скорость при педали газа на 100 градусов = " + vazEngine.ChangeDumperPosition(100));

            Tesla tesla = new Tesla(new Pedals[] { new GasPedal(), new BrakePedal() }, new TeslaSuspention(), new TeslaEngine(), "Р131ТЕ40");
            Console.WriteLine(tesla.StartsUp());
            Console.WriteLine(tesla.ToString());
        }

       

    }
}