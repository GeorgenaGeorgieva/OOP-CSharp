﻿namespace Animals
{
    public interface IAnimal
    {
        string Name { get; }
        string FavouriteFood { get; }
        string ExplainSelf();
    }
}
