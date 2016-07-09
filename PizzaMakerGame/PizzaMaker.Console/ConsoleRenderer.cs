namespace ConsoleRenderer
{
    using System;
    using System.Collections.Generic;
    using System.Text;
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
            StringBuilder builder = new StringBuilder();
            var price = pizza.Price;

            builder.AppendLine(pizza.Name);
            builder.AppendLine("Chosen ingredients: ");
            foreach (var addition in pizza.Additions)
            {
                price += addition.Quantity * addition.Price;
                builder.AppendLine(string.Format("->{0} - {1}", addition.Name, addition.Quantity));
            }

            builder.AppendLine(string.Format("Total price: ${0}", price));
            Console.WriteLine(builder.ToString());
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
