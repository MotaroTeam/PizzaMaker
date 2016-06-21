namespace PizzaMaker.Models.BaseClasses
{
    using System.Collections.Generic;
    using Enums;
    using Interfaces;

    public abstract class Pizza : IPizza
    {
        protected Pizza()
        {
        }

        public Size Size { get; }

        public For For { get; set; }

        public ICollection<IAdditives> Additions { get; }
    }
}
