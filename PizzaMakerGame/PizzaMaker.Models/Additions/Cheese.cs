namespace PizzaMaker.Models.Additions
{
    using BaseClasses;

    public class Cheese : Addition
    {
        const decimal PRICE = 1m;
        const int QUANTITY_PER_SERVING = 50; // quantity per serving
        const int CALORIES = 120;
        const bool VEGETARIAN = false;

        public Cheese(int quantity)
            : base(quantity)
        {
            this.isVegetarian = VEGETARIAN;
            this.calories = quantity * CALORIES;
            this.quantity = quantity * QUANTITY_PER_SERVING;
        }
        
        public override decimal Price
        {
            get { return PRICE; }
        }
    }
}
