namespace PizzaMaker.Models.Additions.Vegetables
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using BaseClasses;

    public class Tomatoe : Addition
    {
        const decimal PRICE = 0.8m;
        const int QUANTITY_PER_SERVING = 62;  // quantity per serving
        const int CALORIES = 11;
        const bool VEGETARIAN = true;

        public Tomatoe(int quantity)
            : base(quantity)
        {
            this.isVegetarian = VEGETARIAN;
            this.calories = quantity * CALORIES;
            this.quantity = quantity * QUANTITY_PER_SERVING;
        }

        public override decimal Price
        {
            get { return PRICE * QUANTITY_PER_SERVING; }
        }
    }
}
