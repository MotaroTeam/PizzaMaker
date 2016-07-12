namespace ConsoleRenderer
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Common;
    using PizzaMaker.Models;
    using PizzaMaker.Models.Interfaces;

    public class ConsoleRenderer : IRenderer
    {
        public ConsoleRenderer()
        {
            Console.WindowWidth = 100;
            Console.BufferWidth = 100;

            Console.CursorVisible = false;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
        }

        public void PrintMenu(IPizza pizza)
        {
            Console.Clear();
            AdditionMenu.PrintMenu(pizza.Additions);
        }

        public DeliveryClient GetClientDetails()
        {
            Console.WriteLine("Enter client name: ");

            var clientName = Console.ReadLine();

            Console.WriteLine("Enter client address: ");

            var clientAdress = Console.ReadLine();

            Console.WriteLine("Enter client phone number: ");

            var clientNumber = Console.ReadLine();

            return new DeliveryClient(clientName, clientAdress, clientNumber);
        }

        public string Input(string prompt = "")
        {
            Console.Write(string.IsNullOrWhiteSpace(prompt) ? string.Empty : prompt + ": ");
            var input = Console.ReadLine();

            return input;
        }

        public int InputFromEnum<T>(string prompt = "", ConsoleColor color = GlobalConstants.DefaultColor)
            where T : struct
        {
            Console.WriteLine(GlobalConstants.SmallSeparator);

            Console.ForegroundColor = color;
            foreach (var e in Enum.GetValues(typeof(T)))
            {
                Console.WriteLine(e + " - " + (int)e);
            }

            Console.ForegroundColor = GlobalConstants.DefaultColor;

            Console.WriteLine(GlobalConstants.SmallSeparator);
            Console.WriteLine(prompt);
            Console.WriteLine(GlobalConstants.SmallSeparator);

            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || !Enum.IsDefined(typeof(T), input))
            {
                Console.WriteLine("No such option");
                Console.Write("Choose again: ");
            }

            Console.WriteLine("Your choice: {0}", Enum.GetName(typeof(T), input));
            Console.WriteLine(GlobalConstants.BiggerSeparator);

            return input;
        }

        public void RenderPizza(IPizza pizza)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(pizza.Name);
            builder.AppendLine("Chosen ingredients: ");
            foreach (var addition in pizza.Additions)
            {
                builder.AppendLine(string.Format("->{0} - {1}", addition.Name, addition.Quantity));
            }

            builder.AppendLine(string.Format("Total price: ${0}", pizza.Price));
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
