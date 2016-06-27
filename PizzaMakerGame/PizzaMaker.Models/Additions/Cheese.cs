namespace PizzaMaker.Models.Additions
{
    using BaseClasses;

    public class Cheese : Addition
    {
        private decimal price = 2m;

        public Cheese(int quantity)
            : base(quantity)
        {
        }

        public override decimal Price
        {
            get { return this.price; }
        }
    }
}
