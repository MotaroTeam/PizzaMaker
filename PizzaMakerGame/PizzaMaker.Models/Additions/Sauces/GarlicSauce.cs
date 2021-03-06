﻿namespace PizzaMaker.Models.Additions.Sauces
{
    using BaseClasses;
    using Common;

    public class GarlicSauce : Addition
    {
        private const int CALORIES = 53; 
        private const bool VEGETARIAN = true;

        public GarlicSauce(int quantity)
            : base(quantity)
        {
            this.IsVegetarian = VEGETARIAN;
            this.Calories = quantity * CALORIES;
            this.Quantity = quantity * GlobalConstants.SAUCE_QUANTITY;
        }

        public override decimal Price
        {
            get
            {
                return GlobalConstants.SAUCE_PRICE * this.Quantity;
            }
        }
    }
}