using static MagicFactory.Car.Engine;
using static MagicFactory.Car.Engine.ElectricEngine;
using static MagicFactory.Car.Engine.InternalCombustionEngine;

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
            Console.WriteLine("Тестируем теслу: " + teslaEngine.TurnOn() + "Скорость при педали газа на 50 градусов = " + teslaEngine.ChangeDumperPosition(50));
            
            VazEngine vazEngine = new VazEngine();
            Console.WriteLine("Тестируем VAZ: " + vazEngine.TurnOn() + "Скорость при педали газа на 50 градусов = " + vazEngine.ChangeDumperPosition(50));

            teslaEngine.ChangeDumperPosition(50);
        }

       

    }
}