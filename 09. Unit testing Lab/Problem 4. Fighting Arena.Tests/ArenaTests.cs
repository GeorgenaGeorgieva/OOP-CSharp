namespace FightingArena.Tests
{
    using NUnit.Framework;

    public class ArenaTests
    {
        private Arena arena;
        private Warrior ahil;
        private Warrior hector;
        private Warrior evripil;

        [SetUp]
        public void Setup()
        {
            this.arena = new Arena();

            this.ahil = new Warrior("Ahil", 60, 70);
            this.hector = new Warrior("Hector", 80, 50);
            this.evripil = new Warrior("Evripil", 70, 60);

            this.arena.Enroll(this.ahil);
            this.arena.Enroll(this.hector);
            this.arena.Enroll(this.evripil);
        }

        [Test]
        public void ConstructorShouldWorkCorrectly()
        {
            Assert.AreNotEqual(null, this.arena);
        }

        [Test]
        public void EnrollMethodShouldThrowIfThisWarriorIsAlreadyEnrolledToList()
        {
            Assert.That(() => this.arena.Enroll(this.ahil),
                Throws.InvalidOperationException.With.Message.EqualTo("Warrior is already enrolled for the fights!"));
        }

        [Test]
        public void EnrollMethodShouldWorkCorrectlyAndAddToListNextWarrior()
        {
            int expectedCount = 3;
            int actualArenaCount = this.arena.Count;

            Assert.AreEqual(expectedCount, actualArenaCount);
        }

        [Test]
        public void FightShouldWorkCorrectlyIfAttacerCannotBeFoundAndThrowException()
        {
            string missingAttacerName = "Mahaon";

            Assert.That(() => this.arena.Fight("Mahaon", "Ahil"),
                Throws.InvalidOperationException.With.Message.EqualTo($"There is no fighter with name {missingAttacerName} enrolled for the fights!"));
        }

        [Test]
        public void FightShouldWorkCorrectlyIfDefenderCannotBeFoundAndThrowException()
        {
            string missingDefenderName = "Mahaon";

            Assert.That(() => this.arena.Fight("Ahil", "Mahaon"),
                Throws.InvalidOperationException.With.Message.EqualTo($"There is no fighter with name {missingDefenderName} enrolled for the fights!"));
        }
    }
}