namespace WildFarm.Clases.Animal.Bird
{
    using System.Collections.Generic;
    using WildFarm.Clases.Food;

    public class Owl : Bird
    {
        private const double IncreaseWeightCoefficient = 0.25;

        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        protected override double WeightGain => IncreaseWeightCoefficient;

        public override string ProduceSoundAskForFood()
        {
            return "Hoot Hoot";
        }

        protected override bool PreferredFood(Food food)
        {
            string type = food.GetType().Name;

            if (type != nameof(Meat))
            {
                return false;
            }

            return true;
        }
    }
}
