namespace PizzaMaker.Models.Additions.Meat
{
    using BaseClasses;
    using Globals;

    public class Ham : Addition
    {
        private const decimal PRICE = 0.02m;
        private const int CALORIES = 40;  // per serving
        private const bool VEGETARIAN = false;

        public Ham(int quantity) 
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
