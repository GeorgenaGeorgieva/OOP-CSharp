namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;
     
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        private double totalCalories;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.Toppings = new List<Topping>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public Dough Dough
        {
            private get
            {
                return this.dough;
            }
            set
            {
                this.dough = value;
            }
        }

        public List<Topping> Toppings
        {
            get
            {
                return this.toppings;
            }
            private set
            {
                this.toppings = value;
            }
        }
        
        public int GetCountOfToppings()
        {
            return this.Toppings.Count;
        }

        public void AddTopping(Topping topping)
        {
            if (this.Toppings.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.Toppings.Add(topping);
        }

        public double CalculatePizzaCalories()
        {

            this.totalCalories += this.Dough.CalculateDoughCalories();

            foreach (Topping topping in this.Toppings)
            {
                this.totalCalories += topping.CalculateToppingsCalories();
            }

            return this.totalCalories;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.totalCalories:F2} Calories.".ToString().TrimEnd();
        }
    }
}
