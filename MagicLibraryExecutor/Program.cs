using static MagicFactory.Car.Engine;
using static MagicFactory.Car.Engine.ElectricEngine;
using static MagicFactory.Car.Engine.InternalCombustionEngine;

namespace MagicLibraryExecutor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello bro");
            TestEngine();

        }

        public static void TestEngine()
        {
            Console.WriteLine("Тестируем теслу...");
            TeslaEngine teslaEngine = new TeslaEngine();
            teslaEngine.TurnOn();
            Console.WriteLine("Тестируем VAZ");
            VazEngine vazEngine = new VazEngine();
            vazEngine.TurnOn();
            vazEngine.TurnOff();
        }

    }
}