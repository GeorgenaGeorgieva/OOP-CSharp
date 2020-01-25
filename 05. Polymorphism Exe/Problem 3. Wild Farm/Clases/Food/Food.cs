namespace WildFarm.Clases.Food
{
    using Interfaces;
    using System;

    public abstract class Food : IFood
    {
        private int quantity;

        public Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity
        {
            get { return this.quantity; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.quantity = value;
            }
        }
    }
}
