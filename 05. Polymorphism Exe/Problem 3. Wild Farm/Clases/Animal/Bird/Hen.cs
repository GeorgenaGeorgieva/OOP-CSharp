namespace WildFarm.Clases.Animal.Bird
{
    using System.Collections.Generic;
using WildFarm.Clases.Food;

    public class Hen : Bird
    {
        private const double IncreaseWeightCoefficient = 0.35;

        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        protected override double WeightGain => IncreaseWeightCoefficient;

        public override string ProduceSoundAskForFood()
        {
            return "Cluck";
        }

        protected override bool PreferredFood(Food food)
        {
            string type = food.GetType().Name;

            if (type != nameof(Vegetable) 
                && type != nameof(Meat)
                && type != nameof(Fruit)
                && type != nameof(Seeds))
            {
                return false;
            }

            return true;
        }
    }
}
