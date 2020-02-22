namespace Tests
{
    using NUnit.Framework;
    using TestAxe;

    [TestFixture]
    public class RefactorAxeTests
    {
        private const int AttackPoints = 2;
        private const int DurabilityPoints = 2;
        private const int Health = 10;
        private const int Experience = 10;

        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void SetUp()
        {
            this.axe = new Axe(AttackPoints, DurabilityPoints);
            this.dummy = new Dummy(Health, Experience);
        }

        [TearDown]
        public void CleanUp()
        {
            this.axe = null;
            this.dummy = null;
        }

        [Test]
        public void AxeLoosesDurabilityAfterAttack()
        {
            this.axe.Attack(dummy);
            int expectedResult = DurabilityPoints - 1;

            Assert.That(this.axe.DurabilityPoints, Is.EqualTo(expectedResult),
                "Axe Durability doesn't change after attack.");
        }

        [Test]
        public void AttackingWithBrokenAxeShouldThrow()
        {
            this.axe.Attack(dummy);
            this.axe.Attack(dummy);

            Assert.That(() => this.axe.Attack(this.dummy),
                Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
        }
    }
}
