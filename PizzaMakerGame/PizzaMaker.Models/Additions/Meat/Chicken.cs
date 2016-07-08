namespace PizzaMaker.Models.Additions.Meat
{
    using BaseClasses;
    using Interfaces;

    public class Chicken : Addition, IAdditive
    {
        private const decimal PRICE = 0.35m;
        private const int QUANTITY = 30;  // quantity per serving
        private const int CALORIES = 40;  // per serving
        private const bool VEGETARIAN = false;

        public Chicken(int quantity) 
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
