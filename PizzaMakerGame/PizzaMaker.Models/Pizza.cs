namespace PizzaMaker.Models
{
    using System.Collections.Generic;
    using BaseClasses;
    using Enums;
    using Interfaces;

    public class Pizza : BasePizza
    {
        public Pizza(string name, ForType usage, SizeType size)
            : base(name)
        {
            this.Size = size;
            this.For = usage;
            this.Additions = new List<IAdditive>();
        }
    }
}
