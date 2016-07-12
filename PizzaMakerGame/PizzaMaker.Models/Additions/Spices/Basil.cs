namespace PizzaMaker.Models.Additions.Spices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using BaseClasses;
    using Globals;

    public class Basil : Addition
    {
        private const decimal PRICE = 0.01m; // Per gram.  <-- MInd the price
        private const int CALORIES = 5;
        private const bool VEGETARIAN = true;

        public Basil(int quantity)
            : base(quantity)
        {
            this.IsVegetarian = VEGETARIAN;
            this.Calories = quantity * CALORIES;
            this.Quantity = quantity * GlobalConstants.SPICE_QUANTITY;
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
