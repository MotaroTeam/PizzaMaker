namespace PizzaMaker.Models.BaseClasses
{
    using Interfaces;

    public abstract class Decorator
    {
        private IPizza pizza;

        protected Decorator(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public IPizza Pizza
        {
            get { return this.pizza; }
            set { this.pizza = value; }
        }

        public abstract void Decorate();
    }
}
