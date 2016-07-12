namespace PizzaMaker
{
    using System;
    using System.Linq;
    using ConsoleRenderer;
    using Logic;
    using Models.Enums;

    public static class Startup
    {
        public static void Main()
        {
            var maker = new PizzaMaker(new ConsoleRenderer());

            var command = maker.Render.InputFromEnum<Command>(" What to do? ", ConsoleColor.Black);
            while ((Command)command != Command.Exit)
            {
                switch ((Command)command)
                {
                    case Command.Create:
                        var pizzaName = maker.Render.Input("Pizza name");
                        var forWhere = maker.Render.InputFromEnum<ForType>("Choose for: ");
                        var size = maker.Render.InputFromEnum<SizeType>("Choose size: ");
                        var pizza = maker.Create(pizzaName, (ForType)forWhere, (SizeType)size);

                        maker.Render.RenderPizza(pizza);

                        break;
                    case Command.Sell:
                        var name = maker.Render.Input("Pizza to sell: ");
                        if (maker.Pizzas.All(p => p.Name != name))
                        {
                            break;
                        }

                        maker.Sell(maker.Pizzas.FirstOrDefault(p => p.Name == name));
                        break;
                    case Command.PrintInfo:
                        maker.Render.RenderMakerDetails(maker);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }

                command = maker.Render.InputFromEnum<Command>(" What to do next? ", ConsoleColor.Black);
            }

            Console.ReadKey();
        }
    }
}