using Xunit;
using MagicFactory.Car;
using MagicFactory;
using static MagicFactory.Car.Suspention;
using static MagicFactory.Car.Car;

namespace MagicFactory.Tests
{
    public class TransportValidationTests
    {
        [Fact]
        public void TheEffecT_SuspensionShaft_Speedwheel()
        {
            // arrange
            var suspension = new TeslaSuspention();
            var wheels = new[]
            {
                new Wheels { Size = 16, Speed = 0 },
                new Wheels { Size = 16, Speed = 0 },
                new Wheels { Size = 16, Speed = 0 },
                new Wheels { Size = 16, Speed = 0 }
            };
            suspension.wheels = wheels;
            // act
            suspension.ChangeSpeed(120);
            // assert
            foreach (var wheel in wheels)
            {
                Assert.Equal(30, wheel.Speed);
            }
        }

        [Fact]
        public void ChangeDumperPosition_TestValue()
        {
            //arrange
            var engine = new Engine.CarEngine.ElectricEngine.TeslaEngine();
            //act
            int changeResult = engine.ChangeDumperPosition(100);
            //assert
            Assert.Equal(111, changeResult);
        }

        [Fact]
        public void GasPedal_EventPress_IncreaseEngineSpeed()
        {
            //arrange
            Pedals[] pedals = new Pedals [] { new GasPedal(), new BrakePedal()};
            var suspention = new TeslaSuspention();
            var engine = new Engine.CarEngine.ElectricEngine.TeslaEngine();
            var registrationNumber = "Р131ТЕ40";
            Car.Car car = new Tesla(pedals, suspention, engine, registrationNumber);

            double startSpeed = engine.Speed;   //Speed = 0
            //act
            car.GasPedal_EventPress(this, EventArgs.Empty);
            double afterSpeed = engine.Speed;
            //assert
            Assert.True(startSpeed < afterSpeed);
        }



    }
}