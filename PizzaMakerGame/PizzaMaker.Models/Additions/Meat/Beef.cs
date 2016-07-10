namespace PizzaMaker.Models.Additions.Meat
{
    using BaseClasses;
    using Globals;

    public class Beef : Addition
    {
        private const decimal PRICE = 0.04m;
        private const int CALORIES = 75;  // per serving
        private const bool VEGETARIAN = false;

        public Beef(int quantity) 
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
