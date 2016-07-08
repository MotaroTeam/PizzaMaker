﻿namespace PizzaMaker.Models.Additions.Sauces
{
    using BaseClasses;
    using Globals;

    public class Pesto : Addition
    {
        private const int CALORIES = 117; 
        private const bool VEGETARIAN = true;

        public Pesto(int quantity)
            : base(quantity)
        {
            this.isVegetarian = VEGETARIAN;
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