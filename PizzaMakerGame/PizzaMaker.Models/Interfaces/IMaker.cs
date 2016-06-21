namespace PizzaMaker.Models.Interfaces
{
    using System.Collections.Generic;

    public interface IMaker
    {
        decimal Balance { get; set; }

        void Buy(IAdditives resource);

        void Sell(IPizza pizza);

        IPizza Create(ICollection<IAdditives> additions);

        void Deliver(ICollection<IPizza> pizzas, string adress);
    }
}
