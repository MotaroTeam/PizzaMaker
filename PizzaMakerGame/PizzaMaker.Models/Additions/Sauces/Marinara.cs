namespace PizzaMaker.Models.Additions.Sauces
{
    using BaseClasses;
    using Common;

    public class Marinara : Addition
    {
        private const int CALORIES = 25; 
        private const bool VEGETARIAN = true;

        public Marinara(int quantity)
            : base(quantity)
        {
            this.IsVegetarian = VEGETARIAN;
            this.Calories = quantity * CALORIES;
            this.Quantity = quantity * GlobalConstants.SAUCE_QUANTITY;
        }

        public override decimal Price
        {
            get
            {
                return GlobalConstants.SAUCE_PRICE * this.Quantity;
            }
        }
    }
}
