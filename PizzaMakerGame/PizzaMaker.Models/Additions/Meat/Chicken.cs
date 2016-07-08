using PizzaMaker.Models.BaseClasses;
using PizzaMaker.Models.Interfaces;

namespace PizzaMaker.Models.Additions.Meat
{
    class Chicken : Addition, IAdditive
    {
        private const decimal PRICE = 0.35m;
        private const int QUANTITY = 30;  // quantity per serving
        private const int CALORIES = 40;  // per serving
        private const bool VEGETARIAN = false;

        public Chicken(int quantity) : base(quantity)
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
