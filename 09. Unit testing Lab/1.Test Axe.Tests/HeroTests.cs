namespace Tests
{
    using Moq;
    using NUnit.Framework;
    using TestAxe;
    using TestAxe.Contracts;

    [TestFixture]
    public class HeroTests
    {
        private const string NameHero = "Gosho";

        private Mock<IWeapon> fakeWeapon;
        private Mock<ITarget> fakeTarget;
        private Hero hero;
 
       [SetUp]
       public void Setup()
        {
            this.fakeWeapon = new Mock<IWeapon>();
            this.fakeTarget = new Mock<ITarget>();
            this.hero = new Hero(NameHero, this.fakeWeapon.Object);
        }

        [TearDown]
        public void CleanUp()
        {
            this.fakeTarget = null;
            this.fakeWeapon = null;
            this.hero = null;
        }

        [Test]
        public void HeroGainsExperienceAfterAttackIfTargetDies()
        {
            this.fakeTarget.Setup(p => p.Health)
                .Returns(0);
            this.fakeTarget.Setup(p => p.IsDead())
                .Returns(true);
            this.fakeTarget.Setup(p => p.GiveExperience())
                .Returns(10);

            this.hero.Attack(this.fakeTarget.Object);

            Assert.That(this.hero.Experience, Is.EqualTo(10));
        }
    }
}
