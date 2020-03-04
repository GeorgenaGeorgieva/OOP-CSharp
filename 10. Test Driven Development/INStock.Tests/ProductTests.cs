namespace INStock.Tests
{
    using System;
    using Contracts;
    using NUnit.Framework;

    [TestFixture]
    public class ProductTests
    {
        [SetUp]
        public void SetUp()
        {
            string label = "milka";
            decimal price = 1.80M;
            int quantity = 20;

            IProduct product = new Product(label, price, quantity);
        }
        
        [Test]
        public void TestConstructor()
        {
            string label = "milka";
            decimal price = 1.80M;
            int quantity = 20;
            IProduct product = new Product(label, price, quantity);

            Assert.AreEqual(label, product.Label);
            Assert.AreEqual(price, product.Price);
            Assert.AreEqual(quantity, product.Quantity);
        }
        [Test]
        public void ProductConstructorTestsIfLabelIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new Product(null, 1.80M, 20));
        }

        [TestCase(0)]
        [TestCase(-1.80)]
        public void ProductConstructorTestsIfPriceIsNegativeNumberOrZero(decimal price)
        {
            Assert.Throws<ArgumentException>(() => new Product("milka", price, 20));
        }

        [Test]
        public void ProductConstructorTestsIfQuantityIsNegativeNumber()
        {
            Assert.Throws<ArgumentException>(() => new Product("milka", 1.80M, -20));
        }

        [Test]
        public void CompareToMethodShouldReturnLabelWithGreaterAsciiCode()
        {
            string graterProductLabel = "zoom";
            decimal graterProductPrice = 34.12M;
            int graterProductQuantity = 4;

            string smallerProductLabel = "do";
            decimal smallerProductPrice = 12.56M;
            int smallerProductQuantity = 5;

            IProduct graterProduct = new Product(graterProductLabel, graterProductPrice, graterProductQuantity);
            IProduct smallerProduct = new Product(smallerProductLabel, smallerProductPrice, smallerProductQuantity);

            int result = graterProduct.CompareTo(smallerProduct);

            Assert.That(() => result, Is.EqualTo(1));
        }
    }
}