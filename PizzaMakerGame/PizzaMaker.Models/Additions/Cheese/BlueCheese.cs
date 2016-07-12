namespace PizzaMaker.Models.Additions.Cheese
{
    using BaseClasses;
    using Common;

    public class BlueCheese : Addition
    {
        private const decimal PRICE = 0.02m; // Per gram.  <-- MInd the price
        private const int CALORIES = 140;
        private const bool VEGETARIAN = true;

        public BlueCheese(int quantity)
            : base(quantity)
        {
            this.IsVegetarian = VEGETARIAN;
            this.Calories = quantity * CALORIES;
            this.Quantity = quantity * GlobalConstants.CHEESE_QUANTITY;
        }

        public override decimal Price
        {
            get
            {
                return PRICE * this.Quantity;
            }
        }
    }
}
