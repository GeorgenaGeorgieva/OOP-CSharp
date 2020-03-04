namespace INStock.Tests.Contracts
{
    public interface IProduct 
    {
        string Label { get; }

        decimal Price { get; }

        int Quantity { get; }

        int CompareTo(IProduct otherProduct);
    }
}