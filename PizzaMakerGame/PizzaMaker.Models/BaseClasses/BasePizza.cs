namespace PizzaMaker.Models.BaseClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Enums;
    using Interfaces;

    public abstract class BasePizza : IPizza
    {
        private string name;

        protected BasePizza(string name)
        {
            this.name = name;
        }

        public decimal Price
        {
            get
            {
                decimal pizzaPrice;
                switch (this.Size)
                {
                    case SizeType.Small: pizzaPrice = 2m;
                        break;
                    case SizeType.Medium: pizzaPrice = 4m;
                        break;
                    case SizeType.Large: pizzaPrice = 6m;
                        break;
                    default:
                        throw new ArgumentException("No Such Size");
                }

                pizzaPrice += this.Additions.Sum(addition => addition.Price);

                return pizzaPrice;
            }
        }

        public string Name => $"{this.Size} {this.name}";

        public SizeType Size { get; set; }

        public ForType For { get; set; }

        public IList<IAdditive> Additions { get; set; }
    }
}
