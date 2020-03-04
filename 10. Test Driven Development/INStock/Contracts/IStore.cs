namespace INStock.Tests.Contracts
{
    using System.Collections.Generic;

    public interface IStore 
    {
        void AddProduct(IProduct product);

        bool Contains(IProduct product);

        int Count { get; }

        IProduct Find(int index);

        IProduct FindByLabel(string label);

        List<IProduct> FindAllInPriceRange(decimal minPrice, decimal maxPrice);

        List<IProduct> FindAllByPrice(decimal price);

        IProduct FindMostExpensiveProduct();

        List<IProduct> FindAllByQuantity(int quantity);

        List<IProduct> GetEnumerator();

        IProduct this[int index] { get; set; }
    }
}