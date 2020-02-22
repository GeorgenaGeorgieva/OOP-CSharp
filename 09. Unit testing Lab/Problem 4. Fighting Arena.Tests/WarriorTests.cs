namespace FightingArena.Tests
{
    using NUnit.Framework;

    public class WarriorTests
    {
        private const int MIN_ATTACK_HP = 30;
        private Warrior warrior;

        [SetUp]
        public void Setup()
        {
            this.warrior = new Warrior("Ahil", 100, 40);
        }

        [Test]
        public void ConstructorShouldWorkCorrectly()
        {
            Assert.AreNotEqual(null, this.warrior);
        }

        [Test]
        public void NameShouldThrowIfItIsNull()
        {
            Assert.That(() => new Warrior(null, 100, 20), 
                Throws.ArgumentException.With.Message.EqualTo("Name should not be empty or whitespace!"));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void DamageShouldThrowIfItIsZeroOrNegativeNumber(int damage)
        {
            Assert.That(() => new Warrior("Ahil", damage, 20),
                Throws.ArgumentException.With.Message.EqualTo("Damage value should be positive!"));
        }

        [Test]
        public void HPShouldThrowIfItIsNegativeNumber()
        {
            Assert.That(() => new Warrior("Ahil", 100, -20),
                Throws.ArgumentException.With.Message.EqualTo("HP should not be negative!"));
        }

        [TestCase(30)]
        [TestCase(29)]
        public void AttackMethodShouldThrowIfOurWrriorHasNotEnoughHP(int hp)
        {
            Warrior hector = new Warrior("Hector", 120, hp);
            Warrior enemy = this.warrior;

            Assert.That(() => hector.Attack(enemy), 
                Throws.InvalidOperationException.With.Message.EqualTo("Your HP is too low in order to attack other warriors!"));
        }

        [TestCase(30)]
        [TestCase(29)]
        public void AttackMethodShouldThrowIfEnemyWrriorHasNotEnoughHP(int hp)
        {
            Warrior enemy = new Warrior("Hector", 120, hp);

            Assert.That(() => this.warrior.Attack(enemy),
                Throws.InvalidOperationException.With.Message.EqualTo($"Enemy HP must be greater than {MIN_ATTACK_HP} in order to attack him!"));
        }

        [Test]
        public void AttackMethodShouldThrowIfEnemyDamageIsMoreWarriorHp()
        {
            Warrior enemy = new Warrior("Hector", 120, 35);

            Assert.That(() => this.warrior.Attack(enemy),
                Throws.InvalidOperationException.With.Message.EqualTo($"You are trying to attack too strong enemy"));
        }

        [Test]
        public void AttackMethodShouldWorkCorrectlyAndDecreaseOurWarriorHP()
        {
            Warrior enemy = new Warrior("Hector", 35, 40);

            this.warrior.Attack(enemy);
            int expectedWarriorHp = 5;

            Assert.AreEqual(expectedWarriorHp, this.warrior.HP);
        }

        [Test]
        public void TestAttackMethodIfOurWarriorDamageIsBiggerThanEnemyHp()
        {
            Warrior enemy = new Warrior("Hector", 35, 40);

            this.warrior.Attack(enemy);
            int expectedEnemyHp = 0;

            Assert.AreEqual(expectedEnemyHp, enemy.HP);
        }

        [Test]
        public void TestAttackMethodIfOurWarriorDamageIsLessThanEnemyHp()
        {
            Warrior enemy = new Warrior("Hector", 35, 120);

            this.warrior.Attack(enemy);
            int expectedEnemyHp = 20;

            Assert.AreEqual(expectedEnemyHp, enemy.HP);
        }
    }
}