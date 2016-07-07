namespace PizzaMaker.Models.Additions.Sauces
{
    using BaseClasses;

    public class Ranch : Addition
    {
        private const decimal PRICE = 0.15m;
        private const int QUANTITY = 30; // quantity per serving
        private const int CALORIES = 102; // per serving
        private const bool VEGETARIAN = true;

        public Ranch(int quantity)
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
