namespace PizzaMaker.Models.Additions.Sauces
{
    using BaseClasses;

    public class Marinara : Addition
    {
        private const decimal PRICE = 0.05m;
        private const int QUANTITY = 50; // quantity per serving
        private const int CALORIES = 25; // per serving
        private const bool VEGETARIAN = true;

        public Marinara(int quantity)
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
