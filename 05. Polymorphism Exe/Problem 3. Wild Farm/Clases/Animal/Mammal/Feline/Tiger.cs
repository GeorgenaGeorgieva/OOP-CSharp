namespace WildFarm.Clases.Animal.Mammal.Feline
{
    using WildFarm.Clases.Food;

    public class Tiger : Feline
    {
        private const double IncreaseWeightCoefficient = 1;

        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override double WeightGain => IncreaseWeightCoefficient;

        public override string ProduceSoundAskForFood()
        {
            return "ROAR!!!";
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
