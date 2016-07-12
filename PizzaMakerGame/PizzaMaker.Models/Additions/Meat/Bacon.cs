namespace PizzaMaker.Models.Additions.Meat
{
    using BaseClasses;
    using Common;

    public class Bacon : Addition
    {
        private const decimal PRICE = 0.03m;
        private const int CALORIES = 100;   // per serving
        private const bool VEGETARIAN = false;

        public Bacon(int quantity) 
            : base(quantity)
        {
            this.IsVegetarian = VEGETARIAN;
            this.Calories = quantity * CALORIES;
            this.Quantity = quantity * GlobalConstants.MEAT_QUANTITY;
        }

        public override decimal Price
        {
            get { return PRICE * this.Quantity; }
        }
    }
}
