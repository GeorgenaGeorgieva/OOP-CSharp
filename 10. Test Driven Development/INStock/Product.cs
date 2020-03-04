namespace INStock.Tests
{
    using System;
    using Contracts;

    public class Product : IProduct
    {
        private string label;
        private decimal price;
        private int quantity;

        public Product(string label, decimal price, int quantity)
        {
            this.Label = label;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string Label 
        {
            get
            {
                return this.label.ToLower();
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Product label cannot be null.");
                }

                this.label = value;
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
                if (value <= 0)
                {
                    throw new ArgumentException("Product price cannot be less than zero.");
                }

                this.price = value;
            }
        }

        public int Quantity 
        {
            get
            {
                return this.quantity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Quantity cannot be negative number.");
                }

                this.quantity = value;
            }
        }

        public int CompareTo(IProduct otherProduct)
        {
            return this.Label.CompareTo(otherProduct.Label);
        }
    }
}