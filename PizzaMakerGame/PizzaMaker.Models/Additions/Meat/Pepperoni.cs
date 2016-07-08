namespace PizzaMaker.Models.Additions.Meat
{
    using BaseClasses;
    using Interfaces;

    public class Pepperoni : Addition, IAdditive
    {
        private const decimal PRICE = 0.35m;
        private const int QUANTITY = 30;   // quantity per serving
        private const int CALORIES = 80;    // per serving
        private const bool VEGETARIAN = false;

        public Pepperoni(int quantity) 
            : base(quantity)
        {
            this.IsVegetarian = VEGETARIAN;
            this.Calories = quantity * CALORIES;
            this.Quantity = quantity * QUANTITY;
        }

        public override decimal Price
        {
            get { return PRICE; }
        }
    }
}
