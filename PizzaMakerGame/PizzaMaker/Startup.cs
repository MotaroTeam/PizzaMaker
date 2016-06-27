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
            var pizza = new Pizza("Yaka Pica", For.Here, Size.Large);

            var sausageDecorator = SausageDecorator.Instance;

            sausageDecorator.Decorate(pizza, 2);

            var cheeseDecorator = CheeseDecorator.Instance;

            cheeseDecorator.Decorate(pizza, 3);

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
    }
}