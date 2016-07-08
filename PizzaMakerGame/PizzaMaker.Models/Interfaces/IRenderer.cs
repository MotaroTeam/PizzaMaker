namespace PizzaMaker.Models.Interfaces
{
    using System.Collections.Generic;

    public interface IRenderer
    {
        string Input();

        void RenderPizza(IPizza pizza);

        void RenderAdditions(ICollection<IAdditive> additions);

        void RenderAdditionDetails(IAdditive addition);

        void RenderMakerDetails(IMaker maker);
    }
}
