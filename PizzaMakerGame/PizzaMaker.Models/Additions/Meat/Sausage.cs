﻿namespace PizzaMaker.Models.Additions.Meat
{
    using BaseClasses;

    public class Sausage : Addition
    {

        private const decimal PRICE = 0.30m;
        private const int QUANTITY = 35;   // quantity per serving
        private const int CALORIES = 90;  // per serving
        private const bool VEGETARIAN = false;

        public Sausage(int quantity)
            : base(quantity)
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