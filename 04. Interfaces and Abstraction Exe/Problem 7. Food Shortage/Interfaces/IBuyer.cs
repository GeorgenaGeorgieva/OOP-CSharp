namespace FoodShortage.Interfaces
{
    public interface IBuyer
    {
        int Age { get; }
        int Food { get; }
        int BuyFood();
    }
}
