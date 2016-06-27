namespace PizzaMaker.Models
{
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

        public IPizza Create(string name, For usage, Size size)
        {
            throw new System.NotImplementedException();
        }

        public void Deliver(string adress)
        {
            throw new System.NotImplementedException();
        }
    }
}
