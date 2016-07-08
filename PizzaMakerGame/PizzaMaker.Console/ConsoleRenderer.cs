namespace ConsoleRenderer
{
    using System;
    using System.Collections.Generic;
    using PizzaMaker.Models.Interfaces;

    public class ConsoleRenderer : IRenderer
    {
        public string Input()
        {
            var input = Console.ReadLine();

            return input;
        }

        public void RenderPizza(IPizza pizza)
        {
            throw new System.NotImplementedException();
        }

        public void RenderAdditions(ICollection<IAdditive> additions)
        {
            throw new System.NotImplementedException();
        }

        public void RenderAdditionDetails(IAdditive addition)
        {
            throw new System.NotImplementedException();
        }

        public void RenderMakerDetails(IMaker maker)
        {
            throw new System.NotImplementedException();
        }
    }
}
