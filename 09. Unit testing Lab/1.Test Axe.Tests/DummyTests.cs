namespace Tests
{
    using NUnit.Framework;
    using TestAxe;

    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyLosesHealthIfAttacked()
        {
            Dummy dummy = new Dummy(10, 10);

            dummy.TakeAttack(10);

            Assert.That(dummy.Health, Is.EqualTo(0));
        }

        [Test]
        public void DeadDummyThrowsExceptionIfAttacked()
        {
            Dummy dummy = new Dummy(0, 10);

            Assert.That(() => dummy.TakeAttack(2),
                Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
        }

        [Test]
        public void DeadDummyCanGiveExperience()
        {
            Axe axe = new Axe(10, 10);
            Hero hero = new Hero("Pesho", axe);
            Dummy dummy = new Dummy(10, 20);

            hero.Attack(dummy);

            Assert.That(hero.Experience, Is.EqualTo(20));
        }

        [Test]
        public void AliveDummyCannotGiveExperience()
        {
            Dummy dummy = new Dummy(10, 20);

            Assert.That(() => dummy.GiveExperience(),
                Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."),
                "Alive Dummy can't give experience");
        }
    }
}
