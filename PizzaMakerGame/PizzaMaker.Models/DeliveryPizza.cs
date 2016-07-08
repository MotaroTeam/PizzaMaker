namespace PizzaMaker.Models
{
    using BaseClasses;
    using Interfaces;

    public class DeliveryPizza : BasePizza, IDeliverable
    {
        public DeliveryPizza(string address, string name)
            : base(name)
        {
            this.Address = address;
        }

        public string Address { get; set; }
    }
}
