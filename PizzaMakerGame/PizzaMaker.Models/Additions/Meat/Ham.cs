namespace PizzaMaker.Models.Additions.Meat
{
    using BaseClasses;
    using Interfaces;

    public class Ham : Addition, IAdditive
    {
        private const decimal PRICE = 0.30m;
        private const int QUANTITY = 25;  // quantity per serving
        private const int CALORIES = 40;  // per serving
        private const bool VEGETARIAN = false;

        public Ham(int quantity) 
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
