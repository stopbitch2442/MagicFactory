using MagicFactory.Car;
using static MagicFactory.Car.Car;
using static MagicFactory.Car.Engine;
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

            CarEngine.ElectricEngine.TeslaEngine teslaEngine = new CarEngine.ElectricEngine.TeslaEngine();
            Console.WriteLine("Тестируем теслу: " + teslaEngine.TurnOn() + " Скорость при педали газа на 100 градусов = " + teslaEngine.ChangeDumperPosition(100));

            CarEngine.InternalCombustionEngine.VazEngine vazEngine = new CarEngine.InternalCombustionEngine.VazEngine();
            Console.WriteLine("Тестируем VAZ: " + vazEngine.TurnOn() + " Скорость при педали газа на 100 градусов = " + vazEngine.ChangeDumperPosition(100));

            Tesla tesla = new Tesla(new Pedals[] { new GasPedal(), new BrakePedal() }, new TeslaSuspention(), new CarEngine.ElectricEngine.TeslaEngine(), "Р131ТЕ40");
            Console.WriteLine(tesla.StartsUp());
            Console.WriteLine(tesla.ToString());
        }

       

    }
}