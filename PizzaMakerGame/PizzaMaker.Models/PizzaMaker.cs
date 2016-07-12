namespace PizzaMaker.Models
{
    using System;
    using System.Collections.Generic;
    using Enums;
    using Interfaces;

    public class PizzaMaker : IMaker
    {
        public PizzaMaker(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public decimal Balance { get; set; }

        public ICollection<IDeliverable> PizzasForDelivery { get; set; }

        public void Buy(IAdditive resource)
        {
            throw new System.NotImplementedException();
        }

        public void Sell(IPizza pizza)
        {
            throw new System.NotImplementedException();
        }

        public IPizza Create(string name, ForType usage, SizeType size)
        {
            return new Pizza(name, usage, size);
        }

        public void Deliver(DeliveryClient client)
        {
            Console.WriteLine(client.ToString());
        }
    }
}
