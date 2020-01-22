namespace Animals.Cats
{
    public class Kitten : Cat
    {
        private const string GenderKitten = "Female";

        public Kitten(string name, int age) 
            : base(name, age, GenderKitten)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
