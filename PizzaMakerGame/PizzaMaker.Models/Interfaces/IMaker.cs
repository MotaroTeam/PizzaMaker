namespace PizzaMaker.Models.Interfaces
{
    using System.Collections.Generic;
    using Enums;

    public interface IMaker
    {
        decimal Balance { get; set; }

        ICollection<IDeliverable> PizzasForDelivery { get; set; }

        void Buy(IAdditive resource);

        void Sell(IPizza pizza);

        IPizza Create(string name, ForType usage, SizeType size);

        void Deliver(DeliveryClient client);
    }
}
