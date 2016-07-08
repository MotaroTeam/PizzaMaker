namespace PizzaMaker.Models.Additions.Sauces
{
    using BaseClasses;
    using Globals;

    public class Ketchup : Addition
    {
        private const int CALORIES = 30;
        private const bool VEGETARIAN = true;

        public Ketchup(int quantity)
            : base(quantity)
        {
            this.IsVegetarian = VEGETARIAN;
            this.Calories = quantity * CALORIES;
            this.Quantity = quantity * GlobalConstants.SAUCE_QUANTITY;
        }

        public override decimal Price
        {
            get
            {
                return GlobalConstants.SAUCE_PRICE * this.Quantity;
            }
        }
    }
}
