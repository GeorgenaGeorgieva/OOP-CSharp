namespace HotelReservation
{
    using System;
     
    public class PriceCalculator
    {
        private decimal pricePerDay;
        private int numberOfDays;
        private Season season;
        private Discount discountType;

        public PriceCalculator(string[] commandParts)
        {
            this.pricePerDay = decimal.Parse(commandParts[0]);
            this.numberOfDays = int.Parse(commandParts[1]);
            this.season = Enum.Parse<Season>(commandParts[2]);
            this.discountType = Discount.None;

            if (commandParts.Length == 4)
            {
                this.discountType = Enum.Parse<Discount>(commandParts[3]);
            }
        }

        public decimal CalculatePrice()
        {
            var multiplier = (int)this.season;
            var discountMultiplier = (decimal)this.discountType / 100;
            var priceBeforeDiscount = this.numberOfDays * this.pricePerDay * multiplier;
            var discountedAmount = priceBeforeDiscount * discountMultiplier;

            var finalPrice = priceBeforeDiscount - discountedAmount;

            return finalPrice;
        }
    }
}
