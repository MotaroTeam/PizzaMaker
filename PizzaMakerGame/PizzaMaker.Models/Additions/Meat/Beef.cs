namespace PizzaMaker.Models.Additions.Meat
{
    using BaseClasses;
    using Interfaces;

    public class Beef : Addition, IAdditive
    {
        private const decimal PRICE = 0.45m;
        private const int QUANTITY = 30;  // quantity per serving
        private const int CALORIES = 75;  // per serving
        private const bool VEGETARIAN = false;

        public Beef(int quantity) 
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
