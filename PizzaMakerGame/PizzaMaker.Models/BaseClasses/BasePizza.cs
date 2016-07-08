namespace PizzaMaker.Models.BaseClasses
{
    using System;
    using System.Collections.Generic;
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
                switch (this.Size)
                {
                    case Size.Small: return 2m;
                    case Size.Medium: return 4m;
                    case Size.Large: return 6m;
                    default:
                        throw new ArgumentException("No Such Size");
                }
            }
        }

        public string Name => $"{this.Size} {this.name}";

        public Size Size { get; set; }

        public For For { get; set; }

        public ICollection<IAdditive> Additions { get; set; }
    }
}
