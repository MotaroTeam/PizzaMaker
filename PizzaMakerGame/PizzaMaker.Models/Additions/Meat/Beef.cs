using PizzaMaker.Models.Interfaces;
using PizzaMaker.Models.BaseClasses;

namespace PizzaMaker.Models.Additions.Meat
{
    class Beef : Addition, IAdditive
    {
        private const decimal PRICE = 0.45m;
        private const int QUANTITY = 30;  // quantity per serving
        private const int CALORIES = 75;  // per serving
        private const bool VEGETARIAN = false;

        public Beef(int quantity) : base(quantity)
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
