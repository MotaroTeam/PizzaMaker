namespace PizzaMaker.Models.BaseClasses
{
    using Interfaces;

    public abstract class Addition : IAdditive
    {
        private decimal priceValue;

        protected Addition(int quantity)
        {
            this.Quantity = quantity;
        }

        public string Name => this.GetType().Name;

        public virtual decimal Price
        {
            get { return this.priceValue; }
        }

        public int Quantity { get; set; }
    }
}
