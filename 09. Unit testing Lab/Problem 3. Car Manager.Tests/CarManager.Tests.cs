namespace CarManager.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class CarTests
    {
        private Car car;

        [SetUp]
        public void Setup()
        {
            this.car = new Car("Citroen", "C3", 10, 200);
        }

        [Test]
        public void ConstructorShouldWorkCorrectly()
        {
            Assert.AreNotEqual(null, this.car);
        }

        [Test]
        public void MakeShouldThrowExceptionIfItIsNull()
        {
            Assert.That(() => new Car(null, "C3", 10, 200),
                Throws.ArgumentException.With.Message.EqualTo("Make cannot be null or empty!"));
        }

        [Test]
        public void ModelShouldThrowExceptionIfItIsNull()
        {
            Assert.That(() => new Car("Citroen", null, 10, 200), 
                Throws.ArgumentException.With.Message.EqualTo("Model cannot be null or empty!"));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void FuelConsumptionShouldThrowExceptionIfItIsZeroOrNegativeNumber(double fuelConsumption)
        {
            Assert.That(() => new Car("Citroen", "C3", fuelConsumption, 200), 
                Throws.ArgumentException.With.Message.EqualTo("Fuel consumption cannot be zero or negative!"));
        }

        [Test]
        public void FuelCapacityShouldThrowExceptionIfItIsNegativeNumber()
        {
            Assert.That(() => new Car("Citroen", "C3", 10, -200),
                Throws.ArgumentException.With.Message.EqualTo("Fuel capacity cannot be zero or negative!"));
        }

        [Test]
        public void FuelAmountIsItZero()
        {
            Assert.AreEqual(0, this.car.FuelAmount);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void RefuelShouldThrowExceptionIfParameterFuelToRefuelIsZeroOrNegativeNumber(double fuelToRefuel)
        {
            Assert.That(() => this.car.Refuel(fuelToRefuel), 
                Throws.ArgumentException.With.Message.EqualTo("Fuel amount cannot be zero or negative!"));
        }

        [Test]
        public void RefuelMethodShouldWorkCorrectlyAndIncreaseFuelAmount()
        {
            double fuelToRefuel = 10;
            double expectedFuelAmount = 10;

            this.car.Refuel(fuelToRefuel);

            Assert.AreEqual(expectedFuelAmount, this.car.FuelAmount);
        }

        [Test]
        public void TestRefuelMethodIfRefuelWithFuelMoreThanCapacity()
        {
            double fuelCapacity = 200;

            car.Refuel(250);
            double expectedFuelAmount = 200;

            Assert.AreEqual(expectedFuelAmount, this.car.FuelAmount);
        }

        [Test]
        public void DriveMethodShouldThrowIfDistanceIsTooMuch()
        {
            double distance = 100;

            Assert.That(() => this.car.Drive(distance),
                Throws.InvalidOperationException.With.Message.EqualTo("You don't have enough fuel to drive!"));
        }

        [Test]
        public void DriveMethodShouldWorkCorrectlyAndDecreaseFuelAmount()
        {
            this.car.Refuel(200);
            this.car.Drive(50);
            double expectedFuelAmount = 195;

            Assert.AreEqual(expectedFuelAmount, this.car.FuelAmount);
        }
    }
}