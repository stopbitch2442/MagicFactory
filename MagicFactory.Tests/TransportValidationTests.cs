using Xunit;
using MagicFactory.Car;
using MagicFactory;
using static MagicFactory.Car.Suspention;

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
    }
}