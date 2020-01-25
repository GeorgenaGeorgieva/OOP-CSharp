namespace WildFarm.Interfaces
{
    using WildFarm.Clases.Food;

    public interface IAnimal
    {
        string Name { get; }
        double Weight { get; }
        string ProduceSoundAskForFood();
        void FeedAnimal(Food food);
    }
}
