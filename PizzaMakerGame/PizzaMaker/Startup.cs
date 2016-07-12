namespace PizzaMaker
{
    using System;
    using ConsoleRenderer;
    using Logic;
    using Models.Enums;

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
                maker.Render.PrintMenu(pizza);
                var client = maker.Render.GetClientDetails();

                maker.Deliver(client);
            }

            maker.Render.RenderPizza(pizza);

            Console.ReadKey();
        }
    }
}