namespace PizzaMaker.Models.Additions.Sauces
{
    using BaseClasses;

    public class Alfredo : Addition
    {
        private const decimal PRICE = 0.30m;
        private const int QUANTITY = 30; // quantity per serving
        private const int CALORIES = 49; // per serving
        private const bool VEGETARIAN = true;

        public Alfredo(int quantity)
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
