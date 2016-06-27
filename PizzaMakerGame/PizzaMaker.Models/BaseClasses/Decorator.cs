namespace PizzaMaker.Models.BaseClasses
{
    using Interfaces;

    public abstract class Decorator
    {
        private IPizza pizza;

        protected Decorator()
        {
        }

        public virtual IPizza Decorate(IPizza pizzaToDecorate, int quantity)
        {
            return pizzaToDecorate;
        }
    }
}
