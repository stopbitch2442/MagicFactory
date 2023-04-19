using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicFactory
{
    public enum BodyName
    {
        Car,
        Tank,
        Boat,
        Train,
        Plane,
        Helicopter
    }

    public enum TransportationName
    {
        Tracks,
        Wheels,
        Blades,
        Rails,
        Chassis
    }
    public class MeansOfTransportation // средство передвижения транспорта
    {
       

    }

    public class MachineBody // корпус транспорта
    {
        
      
    }

    public class Transport
    {
        

        private readonly List<string> _outputStrings;

        public  Transport(List<string> outputStrings)
        {
            _outputStrings = outputStrings;
        }
        public static void TransportCreate()
        {
            Console.WriteLine("Собираем нашу чудо технику:");
            Console.WriteLine("1) Собрать рандом, проверить");
            Console.WriteLine("2) Выбрать детали, вывести список что получилось, проверить");

            Random random = new Random();

            Array bodyName = Enum.GetValues(typeof(BodyName));
            BodyName randomBody = (BodyName)bodyName.GetValue(random.Next(bodyName.Length));

            Array transportationName = Enum.GetValues(typeof(TransportationName));
            TransportationName randomTransportation = (TransportationName)transportationName.GetValue(random.Next(transportationName.Length));

            Console.WriteLine($"Корпус: {randomBody}");
            Console.WriteLine($"Средство передвижения: {randomTransportation}");

        //    TestMagicMachine(randomBody, randomTransportation);
        }

    }


}


//Вывод на консоль:
//Собираем нашу чудо технику:
//1) Собрать рандом, проверить
//2) Выбрать детали, вывести список что получилось, проверить


//проверить технику  - метод TestMagicMachine (определённые параметры присущие виду)

//детали - колёса, основа, башня(пушка)

//средства движения - гусеницы, колёса, лопасти, рельсы, шасси
//корпус - машина, танк, катер, поезд, самолёт, вертолёт
