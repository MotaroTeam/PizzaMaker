namespace PizzaMaker.Models.Additions.Sauces
{
    using BaseClasses;

    public class Ketchup : Addition
    {
        private const decimal PRICE = 0.01m;
        private const int QUANTITY = 30; // quantity per serving
        private const int CALORIES = 30;
        private const bool VEGETARIAN = true;

        public Ketchup(int quantity)
            : base(quantity)
        {
            this.isVegetarian = VEGETARIAN;
            this.calories = quantity * CALORIES;
            this.quantity = quantity * QUANTITY;
        }

        public override decimal Price
        {
            get { return PRICE; }
        }
    }
}
