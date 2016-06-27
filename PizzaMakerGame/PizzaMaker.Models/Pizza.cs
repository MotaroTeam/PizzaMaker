namespace PizzaMaker.Models
{
    using System.Collections.Generic;
    using BaseClasses;
    using Enums;
    using Interfaces;

    public class Pizza : BasePizza
    {
        public Pizza(string name, For usage, Size size)
            : base(name)
        {
            this.Size = size;
            this.For = usage;
            this.Additions = new List<IAdditive>();
        }
    }
}
