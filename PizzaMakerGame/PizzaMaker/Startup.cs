namespace PizzaMaker
{
    using System;
    using ConsoleRenderer;
    using Logic;
    using Logic.Decorators;
    using Models;
    using Models.Enums;
    using Models.Enums.ProductType;

    public static class Startup
    {
        public static void Main()
        {
            var maker = new PizzaMaker(new ConsoleRenderer());

            var pizzaName = maker.Render.Input("Pizza name");

            var forWhere = maker.Render.InputFromEnum<ForType>("Choose for: ");

            var size = maker.Render.InputFromEnum<SizeType>("Choose size: ");

            var pizza = maker.Create(pizzaName, (ForType)forWhere, (SizeType)size);

            if (forWhere == 2)
            {
                ConsoleRenderer.PrintMenu(pizza);
                var client = ConsoleRenderer.GetClientDetails();

                maker.Deliver(client);
            }

            maker.Render.RenderPizza(pizza);

            Console.ReadKey();
        }
    }
}