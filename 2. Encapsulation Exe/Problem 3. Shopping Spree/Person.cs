namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Person
    {
        private const int minMoney = 0;
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Bag = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value.Trim()))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < minMoney)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public List<Product> Bag
        {
            get
            {
                return this.bag;
            }
            private set
            {
                this.bag = value;
            }
        }

        public string CanItBeBought(Product product)
        {
            if (this.Money >= product.Price)
            {
                this.Money -= product.Price;
                this.Bag.Add(product);
                return $"{this.Name} bought {product.Type}".ToString();
            }

            return $"{this.Name} can't afford {product.Type}".ToString();
        }

        public override string ToString()
        {
            string boughtProducts = this.Bag.Count == 0 
                ? "Nothing bought" 
                : String.Join(", ", this.Bag.Select(p => p.Type));

            return boughtProducts.ToString().TrimEnd();
        }
    }
}
