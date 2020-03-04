namespace INStock.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;

    public class Store : IStore
    {
        private List<IProduct> products;
        private int count = 0;

        public Store()
        {
            this.products = new List<IProduct>();
            this.Count = count;
        }

        public int Count 
        {
            get
            {
                return this.count;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Count of products cannot be negative number");
                }

                this.count = value;
            }
        }

        public IProduct this[int index]
        {
            get
            {
                return this.products[index];
            }
            set
            {
                this.products[index] = value;
            }
        }

        public void AddProduct(IProduct product)
        {
            if (this.products.Any(p => p.Label == product.Label))
            {
                throw new ArgumentException("This product already exist.");
            }

            this.products.Add(product);
            this.Count++;
        }

        public IProduct Find(int index)
        {
            if (index > this.products.Count - 1 || index < 0)
            {
                throw new IndexOutOfRangeException("Non-existent index.");
            }
           
            return this.products.ElementAt(index);
        }

        public IProduct FindByLabel(string label)
        {
            if (!this.products.Any(p => p.Label == label) || string.IsNullOrEmpty(label))
            {
                throw new ArgumentException("There is no product with this label.");
            }

            return this.products.FirstOrDefault(p => p.Label == label.ToLower());
        }

        public List<IProduct> FindAllInPriceRange(decimal minPrice, decimal maxPrice)
        {
            if (minPrice < 0 || maxPrice < 0)
            {
                throw new ArgumentException("Price cannot be negative number.");
            }

            List<IProduct> productsFound = this.products
                .FindAll(p => p.Price >= minPrice && p.Price <= maxPrice)
                .OrderByDescending(p => p.Price)
                .ToList();

            return productsFound;
        }

        public List<IProduct> FindAllByPrice(decimal price)
        {
            if (price < 0)
            {
                throw new ArgumentException("Price cannot be negative number.");
            }

            List<IProduct> productsFound = this.products
                .FindAll(p => p.Price == price)
                .ToList();

            return productsFound;
        }

        public IProduct FindMostExpensiveProduct()
        {
            if (this.products.Count == 0)
            {
                throw new ArgumentException("Store is empty.");
            }

            IProduct mostExpensive = this.products
                .OrderByDescending(p => p.Price)
                .First();

            return mostExpensive;
        }

        public List<IProduct> FindAllByQuantity(int quantity)
        {
            if (quantity < 0)
            {
                throw new ArgumentException("Quantity cannot be negative number.");
            }

            List<IProduct> productsFound = this.products
                .FindAll(p => p.Quantity >= quantity)
                .ToList();

            return productsFound;
        }

        public List<IProduct> GetEnumerator()
        {
            if (this.products.Count == 0)
            {
                throw new ArgumentException("Store is empty.");
            }

            return this.products;
        }

        public bool Contains(IProduct product)
        {
            if (!this.products.Contains(product))
            {
                throw new ArgumentException("Store does not contains this product.");
            }

            return true;
        }
    }
}