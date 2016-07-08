using PizzaMaker.Models.BaseClasses;
using PizzaMaker.Models.Interfaces;

namespace PizzaMaker.Models.Additions.Meat
{
    class Bacon : Addition, IAdditive
    {
        private const decimal PRICE = 0.40m;
        private const int QUANTITY = 20;   // quantity per serving
        private const int CALORIES = 100;   // per serving
        private const bool VEGETARIAN = false;

        public Bacon(int quantity) : base(quantity)
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
