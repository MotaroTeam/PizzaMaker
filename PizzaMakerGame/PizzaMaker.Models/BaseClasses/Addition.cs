namespace PizzaMaker.Models.BaseClasses
{
    using System;
    using Interfaces;

    public abstract class Addition : IAdditive
    {
        protected decimal priceValue;
        protected int calories;
        protected bool isVegetarian;
        protected int quantity; // number of pieces

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
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Calories of additives cannot be negative");
                }

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
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Quantity of additives cannot be negative");
                }

                this.quantity = value;
            }
        }
      }
}