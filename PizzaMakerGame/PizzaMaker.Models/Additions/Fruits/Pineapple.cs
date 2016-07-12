namespace PizzaMaker.Models.Additions.Fruits
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using BaseClasses;
    using Globals;

    public class Pineapple : Addition
    {
        private const decimal PRICE = 0.01m; // Per gram.  <-- MInd the price
        private const int CALORIES = 120;
        private const bool VEGETARIAN = true;

        public Pineapple(int quantity)
            : base(quantity)
        {
            this.IsVegetarian = VEGETARIAN;
            this.Calories = quantity * CALORIES;
            this.Quantity = quantity * GlobalConstants.FRUIT_QUANTITY;
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