namespace PizzaMaker.Models
{
    using BaseClasses;
    using Interfaces;

    public class DeliveryPizza : BasePizza, IDeliverable
    {
        public DeliveryPizza(DeliveryClient client, string name)
            : base(name)
        {
            this.Client = client;
        }

        public DeliveryClient Client { get; set; }
    }
}
