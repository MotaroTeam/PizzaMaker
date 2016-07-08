namespace PizzaMaker.Models.Additions.Sauces
{
    using BaseClasses;
    using Globals;

    public class Alfredo : Addition
    {
        private const int CALORIES = 49; // Calories are averaged per serving.
        private const bool VEGETARIAN = true;

        public Alfredo(int quantity)
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