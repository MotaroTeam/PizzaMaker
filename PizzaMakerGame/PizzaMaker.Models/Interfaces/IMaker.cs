namespace PizzaMaker.Models.Interfaces
{
    using System.Collections.Generic;
    using global::PizzaMaker.Models.Enums;

    public interface IMaker
    {
        decimal Balance { get; set; }

        ICollection<IDeliverable> PizzasForDelivery { get; set; }

        void Buy(IAdditive resource);

        void Sell(IPizza pizza);

        IPizza Create(string name, For usage, Size size);

        void Deliver(string adress);
    }
}
