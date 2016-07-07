namespace PizzaMaker.Models.Additions
{
    using BaseClasses;

    public class Cheese : Addition
    {
       private const decimal PRICE = 1m;
       private const int QUANTITY = 50; // quantity per serving
       private const int CALORIES = 120;
       private const bool VEGETARIAN = false;

        public Cheese(int quantity)
            : base(quantity)
        {
            this.isVegetarian = VEGETARIAN;
            this.calories = quantity * CALORIES;
            this.quantity = quantity * QUANTITY;
        }
        
        public override decimal Price
        {
            get { return PRICE; }
        }
    }
}
