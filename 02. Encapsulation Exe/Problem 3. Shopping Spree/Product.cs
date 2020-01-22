namespace ShoppingSpree
{
    using System;
    public class Product
    {
        private const int MIN_PRICE = 0;
        private string type;
        private decimal price;

        public Product(string type, decimal price)
        {
            this.Type = type;
            this.Price = price;
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value.Trim()))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.type = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value < MIN_PRICE)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.price = value;
            }
        }
    }
}
