using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicFactory
{
    public class MeansOfTransportation // средство передвижения транспорта
    {
        public enum TransportationName
        {
            Wheels,
            Tracks,
            Blades,
            Rails,
            Chassis
        }
        public string Name { get; set; }

        public MeansOfTransportation(string name)
        {
            Name = name;
        }

    }

    public class MachineBody // корпус транспорта
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
        public string Name { get; set; }

        public MachineBody(string name) 
        {
            Name = name;
        }

    }

    public class Transport
    {
        readonly Random rnd = new Random();
     
    }


}
