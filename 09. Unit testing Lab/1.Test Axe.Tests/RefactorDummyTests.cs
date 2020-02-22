namespace Tests
{
    using NUnit.Framework;
    using TestAxe;

    [TestFixture]
    public class RefactorDummyTests
    {
        private const int AttackPointsAxe = 10;
        private const int DurabilityPointsAxe = 10;
        private const int HealthDummy = 10;
        private const int ExperienceDummy = 10;
        private const string Name = "Gosho";

        private Axe axe;
        private Dummy dummy;
        private Hero hero;

        [SetUp]
        public void TestsInitialize()
        {
            this.dummy = new Dummy(HealthDummy, ExperienceDummy);
            this.axe = new Axe(AttackPointsAxe, DurabilityPointsAxe);
            this.hero = new Hero(Name, this.axe);
        }

        [TearDown]
        public void CleanUp()
        {
            this.dummy = null;
            this.axe = null;
            this.hero = null;
        }

        [Test]
        public void DummyLosesHealthIfAttacked()
        {
            int expectedResult = HealthDummy - AttackPointsAxe;
            this.dummy.TakeAttack(this.axe.AttackPoints);

            Assert.That(this.dummy.Health, Is.EqualTo(expectedResult));
        }

        [Test]
        public void DeadDummyThrowsExceptionIfAttacked()
        {
            int takenHealth = HealthDummy;
            this.dummy.TakeAttack(takenHealth);

            Assert.That(() => this.dummy.TakeAttack(takenHealth),
                Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
        }

        [Test]
        public void DeadDummyCanGiveExperience()
        {
            int expectedExperience = ExperienceDummy;
            this.hero.Attack(this.dummy);

            Assert.That(this.hero.Experience, Is.EqualTo(expectedExperience));
        }

        [Test]
        public void AliveDummyCannotGiveExperience()
        {
            Assert.That(() => this.dummy.GiveExperience(),
                Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."),
                "Alive Dummy can't give experience");
        }
    }
}