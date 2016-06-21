namespace PizzaMaker.Models.BaseClasses
{
    using Interfaces;

    public abstract class Addition : IAdditives
    {
        protected Addition()
        {
        }

        public string Name { get; }

        public int Quantity { get; set; }
    }
}
