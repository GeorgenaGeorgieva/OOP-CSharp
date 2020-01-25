namespace WildFarm.Clases.Animal.Mammal
{
    using WildFarm.Clases.Food;

    public class Mouse : Mammal
    {
        private const double IncreaseWeightCoefficient = 0.10;

        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightGain => IncreaseWeightCoefficient;

        public override string ProduceSoundAskForFood()
        {
            return "Squeak";
        }

        protected override bool PreferredFood(Food food)
        {
            string type = food.GetType().Name;

            if (type != nameof(Vegetable) && type != nameof(Fruit))
            {
                return false;
            }

            return true;
        }
    }
}
