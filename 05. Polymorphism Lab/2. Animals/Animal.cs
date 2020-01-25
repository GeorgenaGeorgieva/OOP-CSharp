using System;

namespace Animals
{
    public abstract class Animal : IAnimal
    {
        private string name;
        private string favouriteFood;

        public Animal(string name, string favoriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favoriteFood;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public string FavouriteFood
        {
            get { return this.favouriteFood; }
            private set { this.favouriteFood = value; }
        }

        public abstract string ExplainSelf();
    }
}
