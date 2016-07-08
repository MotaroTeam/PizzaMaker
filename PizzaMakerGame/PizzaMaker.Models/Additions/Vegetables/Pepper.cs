namespace PizzaMaker.Models.Additions.Vegetables
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using BaseClasses;
    using Globals;

    public class Pepper : Addition
    {
        public const decimal PRICE = 0.04m;
        public const int CALORIES = 20;
        public const bool VEGETARIAN = true;

        public Pepper(int quantity)
            : base(quantity)
        {
            this.isVegetarian = VEGETARIAN;
            this.Calories = quantity * CALORIES;
            this.Quantity = quantity * GlobalConstants.VEGETABLES_QUANTITY;
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
