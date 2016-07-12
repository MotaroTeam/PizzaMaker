namespace PizzaMaker.Models.BaseClasses
{
    using System;
    using Common.Validation;
    using Interfaces;

    public abstract class Addition : IAdditive
    {
        private decimal priceValue;
        private int calories;
        private bool isVegetarian;
        private int quantity; // number of pieces

        protected Addition(int quantity)
        {
        }

        public int Calories
        {
            get
            {
                return this.calories;
            }

            protected set
            {
                ArgumentValidation.NegativeValueValidation(value, "Calories of additives");

                this.calories = value;
            }
        }

        public bool IsVegetarian
        {
            get
            {
                return this.isVegetarian;
            }

            protected set
            {
                this.isVegetarian = value;
            }
        }

        public string Name => this.GetType().Name;

        public virtual decimal Price
        {
            get { return this.priceValue; }
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }

            protected set
            {
                ArgumentValidation.NegativeValueValidation(value, "Quantity of additives");

                this.quantity = value;
            }
        }
    }
}