﻿namespace PizzaMaker.Logic.Decorators
{
    using PizzaMaker.Models.Additions;
    using PizzaMaker.Models.BaseClasses;
    using PizzaMaker.Models.Interfaces;

    public class CheeseDecorator : Decorator
    {
        private static CheeseDecorator instance;

        private CheeseDecorator()
        {
        }

        public static CheeseDecorator Instance => instance ?? (instance = new CheeseDecorator());

        public override IPizza Decorate(IPizza pizza, int quantity)
        {
            pizza.Additions.Add(new Cheese(quantity));

            return pizza;
        }
    }
}