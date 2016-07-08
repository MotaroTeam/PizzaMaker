namespace PizzaMaker.Models.Additions.Meat
{
    using BaseClasses;
    using Interfaces;

    public class Bacon : Addition, IAdditive
    {
        private const decimal PRICE = 0.40m;
        private const int QUANTITY = 20;   // quantity per serving
        private const int CALORIES = 100;   // per serving
        private const bool VEGETARIAN = false;

        public Bacon(int quantity) 
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
