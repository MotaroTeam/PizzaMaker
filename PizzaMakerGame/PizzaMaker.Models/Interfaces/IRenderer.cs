namespace PizzaMaker.Models.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Common;

    public interface IRenderer
    {
        string Input(string prompt);

        int InputFromEnum<T>(string prompt, ConsoleColor color = GlobalConstants.DefaultColor) 
            where T : struct;

        void RenderPizza(IPizza pizza);

        void RenderAdditions(ICollection<IAdditive> additions);

        void RenderAdditionDetails(IAdditive addition);

        void RenderMakerDetails(IMaker maker);
    }
}
