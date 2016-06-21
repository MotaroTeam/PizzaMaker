namespace PizzaMaker.Models.Models
{
    using Interfaces;

    public class Sausage : IAdditives
    {
        private readonly string name = "sausage";

        public Sausage(int quantity)
        {
            this.Quantity = quantity;
        }

        public string Name
        {
            get { return this.name; }
        }

        public int Quantity { get; set; }
    }
}
