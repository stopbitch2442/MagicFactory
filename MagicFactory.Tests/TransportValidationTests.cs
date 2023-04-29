using Xunit;
using MagicFactory.Car;
using MagicFactory;
using static MagicFactory.Car.Suspention;
using static MagicFactory.Car.Car;
using static MagicFactory.Car.Engine;

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
        public void TeslaGasPedalEventTest()
        {
            // Arrange
            GasPedal gasPedal = new GasPedal();
            CarEngine.ElectricEngine.TeslaEngine engine = new CarEngine.ElectricEngine.TeslaEngine();
            bool eventCall = false;

            gasPedal.EventPress += (sender, args) =>
            {
                eventCall = true;
            };

            // Act
            gasPedal.EventPressExecutor();

            // Assert
            Assert.True(eventCall);
        }

        [Fact]
        public void ChangeSpeedGasPedal()
        {
            // Arrange
            CarEngine.ElectricEngine.TeslaEngine teslaEngine = new CarEngine.ElectricEngine.TeslaEngine();
            int nullSpeed = 0;
            // Act
            int speedAfterGas = teslaEngine.ChangeDumperPosition(100);
            // Assert
            Assert.True(nullSpeed < speedAfterGas);
        }



    }
}