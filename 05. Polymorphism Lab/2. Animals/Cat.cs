namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string favoriteFood) 
            : base(name, favoriteFood)
        {
        }

        public override string ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}\nMEEOW";
        }
    }
}
