namespace PizzaCalories
{
    using System;
    public class Dough
    {
        private const double CALORIES_GRAM = 2;
        private string flourType;
        private string backingTechnique;
        private int weight;

        public Dough(string flourType, string backingTechnique, int weight)
        {
            this.FlourType = flourType;
            this.BackingTechnique = backingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get
            { 
                return this.flourType; 
            }
            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string BackingTechnique
        {
            get 
            {
                return this.backingTechnique; 
            }
            private set
            {
                if (value.ToLower() != "crispy"
                    && value.ToLower() != "chewy" 
                    && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.backingTechnique = value;
            }
        }

        public int Weight
        {
            get 
            {
                return this.weight; 
            }
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        public double CalculateDoughCalories()
        {
            double modifier = CALORIES_GRAM;

            if (this.FlourType.ToLower() == "white")
            {
                modifier *= 1.5;
            }
            else if (this.FlourType.ToLower() == "wholegrain")
            {
                modifier *= 1.0;
            }

            if (this.BackingTechnique.ToLower() == "crispy")
            {
                modifier *= 0.9;
            }
            else if (this.BackingTechnique.ToLower() == "chewy")
            {
                modifier *= 1.1;
            }
            else if (this.BackingTechnique.ToLower() == "homemade")
            {
                modifier *= 1.0;
            }

            double calories = modifier * this.Weight;
            return calories;
        }
    }
}
