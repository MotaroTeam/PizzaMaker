namespace ConsoleRenderer
{
    using System;
    using System.Collections.Generic;
    using PizzaMaker.Models.Interfaces;

    public class ConsoleRenderer : IRenderer
    {
        public string Input(string prompt = "")
        {
            Console.Write(string.IsNullOrWhiteSpace(prompt) ? string.Empty : prompt + ": ");
            var input = Console.ReadLine();

            return input;
        }

        public int InputFromEnum<T>(string prompt = "")
            where T : struct
        {
            foreach (var e in Enum.GetValues(typeof(T)))
            {
                Console.WriteLine(e + " - " + (int)e);
            }

            Console.Write(prompt);

            // TODO: rework to TryParse output to exist in the enum
            var input = int.Parse(Console.ReadLine());

            return input;
        }

        public void RenderPizza(IPizza pizza)
        {
            var price = pizza.Price;

            Console.WriteLine(pizza.Name);
            Console.WriteLine("ingredients: ");
            foreach (var addition in pizza.Additions)
            {
                price += addition.Quantity * addition.Price;
                Console.WriteLine($"{addition.Name} - {addition.Quantity}");
            }

            Console.WriteLine("Price: " + price);
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
