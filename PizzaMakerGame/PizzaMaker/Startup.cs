namespace PizzaMaker
{
    using System;
    using Logic.Decorators;
    using Models;
    using Models.Enums;

    public static class Startup
    {
        public static void Main()
        {
            var pizza = new Pizza("Yaka Pica", ForType.Here, SizeType.Large);

            var sauceDecorator = SauceDecorator.Instance;

            sauceDecorator.Decorate(pizza, SauceType.Alfredo, 1);

            var price = pizza.Price;

            Console.WriteLine(pizza.Name);
            Console.WriteLine("ingredients: ");
            foreach (var addition in pizza.Additions)
            {
                price += addition.Quantity * addition.Price;
                Console.WriteLine($"{addition.Name} - {addition.Quantity}");
            }

            Console.WriteLine("Price: " + price);

            Console.ReadKey();
        }
    }
}