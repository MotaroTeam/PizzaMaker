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
                    case SizeType.Small: return 2m;
                    case SizeType.Medium: return 4m;
                    case SizeType.Large: return 6m;
                    default:
                        throw new ArgumentException("No Such Size");
                }
            }
        }

        public string Name => $"{this.Size} {this.name}";

        public SizeType Size { get; set; }

        public ForType For { get; set; }

        public IList<IAdditive> Additions { get; set; }
    }
}
