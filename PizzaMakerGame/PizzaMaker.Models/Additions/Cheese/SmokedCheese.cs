namespace PizzaMaker.Models.Additions.Cheese
{
    using BaseClasses;
    using Globals;

    public class SmokedCheese : Addition
    {
        private const decimal PRICE = 0.1m; // Per gram.  <-- MInd the price
        private const int CALORIES = 137;
        private const bool VEGETARIAN = true;

        public SmokedCheese(int quantity)
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