namespace PizzaMaker.Models.Additions.Meat
{
    using BaseClasses;
    using Globals;

    public class Sausage : Addition
    {
        private const decimal PRICE = 0.02m;
        private const int CALORIES = 90;  // per serving
        private const bool VEGETARIAN = false;

        public Sausage(int quantity)
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
