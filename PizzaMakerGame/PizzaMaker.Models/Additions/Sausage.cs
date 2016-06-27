namespace PizzaMaker.Models
{
    using BaseClasses;

    public class Sausage : Addition
    {
        private decimal price = 1m;

        public Sausage(int quantity)
            : base(quantity)
        {
        }

        public override decimal Price
        {
            get { return this.price; }
        }
    }
}
