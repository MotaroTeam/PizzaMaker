namespace PizzaMaker.Models.BaseClasses
{
    using System;
    using Interfaces;
    
    public abstract class Decorator
    {
        private IPizza pizza;

        protected Decorator()
        {
        }

        public virtual IPizza Decorate(IPizza pizzaToDecorate, Enum type, int quantity)
        {
            return pizzaToDecorate;
        }
    }
}
