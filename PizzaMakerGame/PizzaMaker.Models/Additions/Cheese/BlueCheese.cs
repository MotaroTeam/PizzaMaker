namespace PizzaMaker.Models.Additions.Cheese
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using BaseClasses;
    using Globals;

    public class BlueCheese : Addition
    {
        private const decimal PRICE = 0.1m; // Per gram.  <-- MInd the price
        private const int CALORIES = 120;
        private const bool VEGETARIAN = true;

        public BlueCheese(int quantity)
            : base(quantity)
        {
            this.isVegetarian = VEGETARIAN;
            this.Calories = quantity * CALORIES;
            this.Quantity = quantity * GlobalConstants.CHEESE_QUANTITY;
        }

        public override decimal Price
        {
            get
            {
                return PRICE * this.Quantity;
            }
        }
    }
}
