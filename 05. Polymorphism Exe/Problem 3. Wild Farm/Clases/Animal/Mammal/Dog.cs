namespace WildFarm.Clases.Animal.Mammal
{
    using WildFarm.Clases.Food;

    public class Dog : Mammal
    {
        private const double IncreaseWeightCoefficient = 0.40;

        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightGain => IncreaseWeightCoefficient;

        public override string ProduceSoundAskForFood()
        {
            return "Woof!";
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
