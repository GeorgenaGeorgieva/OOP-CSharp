namespace ExtendedDatabase.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Tests
    {
        [Test]
        public void ConstructorThrowIfArraysCapacityNotBeInRangeFrom0To16()
        {
            Person[] persons = new Person[17];

            Assert.That(() => new ExtendedDatabase(persons),
                Throws.ArgumentException.With.Message.EqualTo(
                    "Provided data length should be in range [0..16]!"));
        }

        [Test]
        public void AddMethodThrowIfThereAreAlreadyUsersWithThisUsername()
        {
            Person gosho = new Person(15, "Gosho");
            Person[] persons = new Person[1] { gosho };
            ExtendedDatabase database = new ExtendedDatabase(persons);

            Assert.That(() => database.Add(new Person(14, "Gosho")),
                Throws.InvalidOperationException.With.Message.EqualTo(
                    "There is already user with this username!"));
        }

        [Test]
        public void AddMethodThrowIfThereAreAlreadyUsersWithThisID()
        {
            Person pesho = new Person(13, "Pesho");
            Person[] persons = new Person[1] { pesho };
            ExtendedDatabase database = new ExtendedDatabase(persons);

            Assert.That(() => database.Add(new Person(13, "Gosho")),
                Throws.InvalidOperationException.With.Message.EqualTo(
                    "There is already user with this Id!"));
        }

        [Test]
        public void AddMethodShouldThrowWhenCountExceeds16()
        {
            Person[] persons = new Person[16];

            for (int i = 0; i < 16; i++)
            {
                Person currentPerson = new Person(i, "Gosho" + $"{i}");
                persons[i] = currentPerson;
            }

            ExtendedDatabase database = new ExtendedDatabase(persons);

            Assert.That(() => database.Add(new Person(18, "Stefan")),
                Throws.InvalidOperationException.With.Message.EqualTo(
                    "Array's capacity must be exactly 16 integers!"));
        }

        [Test]
        public void AddMethodShouldAddCorrectlyAndIncreaseTheCount()
        {
            ExtendedDatabase database = new ExtendedDatabase();

            database.Add(new Person(1, "Gosho"));
            int expectedCount = 1;
            int actualCount = database.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void RemoveOperationShouldThrowIfThereIsNoElementsInCollection()
        {
            ExtendedDatabase database = new ExtendedDatabase();

            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void RemoveElementAndDecreaseTheCountCorrectly()
        {
            Person pesho = new Person(13, "Pesho");
            Person[] persons = new Person[1] { pesho };
            ExtendedDatabase database = new ExtendedDatabase(persons);

            database.Remove();
            int expectedCount = 0;
            int actualCount = database.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void FindByUsernameIfNoUserIsPresentByThisUsername()
        {
            Person pesho = new Person(13, "Pesho");
            Person[] persons = new Person[1] { pesho };
            ExtendedDatabase database = new ExtendedDatabase(persons);
            string username = "Gosho";

            Assert.That(() => database.FindByUsername(username) == null,
                Throws.InvalidOperationException.With.Message.EqualTo(
                    "No user is present by this username!"));
        }

        [Test]
        public void FindByUsernameSouldReturnExsistingPerson()
        {
            Person pesho = new Person(13, "Pesho");
            Person[] persons = new Person[1] { pesho };
            ExtendedDatabase database = new ExtendedDatabase(persons);

            Person expectedPerson = pesho;
            Person actualPerson = database.FindByUsername("Pesho");

            Assert.AreEqual(expectedPerson, actualPerson);
        }

        [Test]
        public void FindByUsernameMethodThrowIfUsernameIsNull()
        {
            ExtendedDatabase database = new ExtendedDatabase();
            string username = null;

            Assert.Throws<ArgumentNullException>(
                () => database.FindByUsername(username), 
                "Method should throw exception when parameter username is null!");
        }

        [Test]
        public void FindByUsernameMethodThrowIfIsCaseSensitive()
        {
            Person pesho = new Person(13, "Pesho");
            Person[] persons = new Person[1] { pesho };
            ExtendedDatabase database = new ExtendedDatabase(persons);

            Assert.That(() => database.FindByUsername("PESHO"), 
                Throws.InvalidOperationException);
        }

        [Test]
        public void FindByIdMethodShouldReturnExsistingUserWithThisID()
        {
            Person pesho = new Person(13, "Pesho");
            Person[] persons = new Person[1] { pesho };
            ExtendedDatabase database = new ExtendedDatabase(persons);

            Person expectedPerson = pesho;
            Person actualPerson = database.FindById(13);

            Assert.AreEqual(expectedPerson, actualPerson);
        }

        [Test]
        public void FindByIdMethodThrowIfNoUserIsPresentByThisId()
        {
            Person pesho = new Person(13, "Pesho");
            Person[] persons = new Person[1] { pesho };
            ExtendedDatabase database = new ExtendedDatabase(persons);
            long id = 2;

            Assert.That(() => database.FindById(id) == null,
                Throws.InvalidOperationException.With.Message.EqualTo(
                    "No user is present by this ID!"));
        }

        [Test]
        public void FindByIdMethodThrowIfNumberOfIdIsNegative()
        {
            ExtendedDatabase database = new ExtendedDatabase();
            long id = -1;

            Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(id));
        }
    }
}