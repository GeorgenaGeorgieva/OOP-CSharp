namespace INStock.Tests
{
    using System;
    using System.Collections.Generic;
    using INStock.Tests.Contracts;
    using NUnit.Framework;

    [TestFixture]
    public class StoreTests
    {
        [Test]
        public void AddMethodSHouldThrowIfTryToAddTheSameProduct()
        {
            Product product = new Product("Milka", 1.80M, 20);
            Store store = new Store();

            store.AddProduct(product);

            Assert.Throws<ArgumentException>(() => store.AddProduct(product));
        }

        [Test] 
        public void AddProductMethodShouldWorkCorrectlyAndIncreaseTheCountOfAddedProduct()
        {
            Product product = new Product("Milka", 1.80M, 20);
            Store store = new Store();

            store.AddProduct(product);

            Assert.AreEqual(1, store.Count);
        }

        [TestCase(-1)]
        [TestCase(3)]
        public void FindMethodShouldThrowIfTryToFindIndexOutOfRange(int index)
        {
            Store store = new Store();

            store.AddProduct(new Product("milka", 1.80M, 20));
            store.AddProduct(new Product("how now", 1.20M, 10));
            store.AddProduct(new Product("kerrygold", 4.50M, 50));

            Assert.Throws<IndexOutOfRangeException>(() => store.Find(index));
        }

        [TestCase(null)]
        [TestCase("Pepsi")]
        public void FindByLabelMethodShouldThrowIfTryToFindNonExistentLabel(string label)
        {
            Store store = new Store();

            store.AddProduct(new Product("milka", 1.80M, 20));
            store.AddProduct(new Product("how now", 1.20M, 10));
            store.AddProduct(new Product("kerrygold", 4.50M, 50));

            Assert.Throws<ArgumentException>(() => store.FindByLabel(label));
        }

        [TestCase(5.60, 10.20)]
        public void FindAllInPriceRangeMethodShouldWorkCorrectly(decimal minPrice, decimal maxPrice)
        {
            Store store = new Store();

            store.AddProduct(new Product("milka", 1.80M, 20));
            store.AddProduct(new Product("how now", 1.20M, 10));
            store.AddProduct(new Product("kerrygold", 4.50M, 50));

            Assert.IsEmpty(store.FindAllInPriceRange(minPrice, maxPrice));
        }

        [TestCase(-5, -1)]
        public void FindAllInPriceRangeMethodShouldThrowIfMinPriceAndMaxPriceAreNegativeNumbers(decimal minPrice, decimal maxPrice)
        {
            Store store = new Store();

            store.AddProduct(new Product("milka", 1.80M, 20));
            store.AddProduct(new Product("how now", 1.20M, 10));
            store.AddProduct(new Product("kerrygold", 4.50M, 50));

            Assert.Throws<ArgumentException>(() => store.FindAllInPriceRange(minPrice, maxPrice));
        }

        [Test]
        public void FindAllByPriceMethodShouldReturnCollectionWithProductsFound()
        {
            Store store = new Store();

            store.AddProduct(new Product("milka", 1.80M, 20));
            store.AddProduct(new Product("how now", 1.20M, 10));
            store.AddProduct(new Product("kerrygold", 4.50M, 50));

            List<IProduct> result = store.FindAllByPrice(1.80M);

            Assert.AreEqual(1, result.Count);
        }

        [Test]
        public void FindAllByPriceMethodShouldThrowIfPriceIsNegativeNumber()
        {
            Store store = new Store();

            store.AddProduct(new Product("milka", 1.80M, 20));
            store.AddProduct(new Product("how now", 1.20M, 10));
            store.AddProduct(new Product("kerrygold", 4.50M, 50));

            Assert.Throws<ArgumentException>(()=> store.FindAllByPrice(-1.80M));
        }

        [Test]
        public void FindAllByPriceMethodShouldEmptyCollectionIfThereIsNoProductsWithThisPrice()
        {
            Store store = new Store();

            store.AddProduct(new Product("milka", 1.80M, 20));
            store.AddProduct(new Product("how now", 1.20M, 10));
            store.AddProduct(new Product("kerrygold", 4.50M, 50));

            Assert.IsEmpty(store.FindAllByPrice(3.50M));
        }

        [Test]
        public void FindMostExpensiveProductsMethodThrowIfStoreIsEmpty()
        {
            Store store = new Store();

            Assert.Throws<ArgumentException>(() => store.FindMostExpensiveProduct());
        }

        [Test]
        public void FindAllByQuantityThrowIfQuantityIsZeroOrNegativeNumber()
        {
            Store store = new Store();

            store.AddProduct(new Product("milka", 1.80M, 20));
            store.AddProduct(new Product("how now", 1.20M, 10));
            store.AddProduct(new Product("kerrygold", 4.50M, 50));

            Assert.Throws<ArgumentException>(() => store.FindAllByQuantity(-1));
        }

        [Test]
        public void FindAllByQuantityShouldReturnEmptyCollectionIfThereIsNoEnoughQuantityOfProducts()
        {
            Store store = new Store();

            store.AddProduct(new Product("milka", 1.80M, 20));
            store.AddProduct(new Product("how now", 1.20M, 10));
            store.AddProduct(new Product("kerrygold", 4.50M, 50));

            Assert.IsEmpty(store.FindAllByQuantity(60));
        }

        [Test]
        public void GetEnumeratorMethodShouldReturnCollectionWithProducts()
        {
            Store store = new Store();

            store.AddProduct(new Product("milka", 1.80M, 20));
            store.AddProduct(new Product("how now", 1.20M, 10));
            store.AddProduct(new Product("kerrygold", 4.50M, 50));

            Assert.IsNotEmpty(store.GetEnumerator());
        }

        [Test]
        public void GetEnumeratorMethodShouldThrowIfCollectionIsEmpty()
        {
            Store store = new Store();

            Assert.Throws<ArgumentException>(() => store.GetEnumerator());
        }

        [Test]
        public void ContainsMethodShouldReturnTrueIfCollectionContainsCurrentProduct()
        {
            Store store = new Store();
            IProduct currentProduct = new Product("milka", 1.80M, 20);

            store.AddProduct(currentProduct);

            Assert.IsTrue(store.Contains(currentProduct));
        }

        [Test]
        public void ContainsMethodShouldThrowIfCollectionDoesNotContainsCurrentProduct()
        {
            Store store = new Store();
            IProduct currentProduct = new Product("milka", 1.80M, 20);

            store.AddProduct(currentProduct);

            Assert.Throws<ArgumentException>(() => store.Contains(new Product("how now", 1.20M, 10)));
        }
    }
}