namespace PizzaMaker.Models.Additions.Cheese
{
    using BaseClasses;
    using Common;

    public class Mozzarella : Addition
    {
        private const decimal PRICE = 0.01m; // Per gram.  <-- MInd the price
        private const int CALORIES = 120;
        private const bool VEGETARIAN = true;

        public Mozzarella(int quantity)
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