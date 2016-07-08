using PizzaMaker.Models.BaseClasses;
using PizzaMaker.Models.Interfaces;

namespace PizzaMaker.Models.Additions.Meat
{
    class Ham : Addition, IAdditive
    {
        private const decimal PRICE = 0.30m;
        private const int QUANTITY = 25;  // quantity per serving
        private const int CALORIES = 40;  // per serving
        private const bool VEGETARIAN = false;

        public Ham(int quantity) : base(quantity)
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
