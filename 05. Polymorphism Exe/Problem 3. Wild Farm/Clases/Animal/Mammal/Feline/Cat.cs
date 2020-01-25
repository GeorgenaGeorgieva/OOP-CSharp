namespace WildFarm.Clases.Animal.Mammal.Feline
{
    using Food;

    public class Cat : Feline
    {
        private const double IncreaseWeightCoefficient = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override double WeightGain => IncreaseWeightCoefficient;

        public override string ProduceSoundAskForFood()
        {
            return "Meow";
        }

        protected override bool PreferredFood(Food food)
        {
            string type = food.GetType().Name;

            if (type != nameof(Meat) && type != nameof(Vegetable))
            {
                return false;
            }

            return true;
        }
    }
}
