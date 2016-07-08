namespace PizzaMaker.Logic.Decorators
{
    using System;
    using Models.Additions.Cheese;
    using Models.BaseClasses;
    using Models.Interfaces;

    public class CheeseDecorator : Decorator
    {
        private static CheeseDecorator instance;

        private CheeseDecorator()
        {
        }

        public static CheeseDecorator Instance => instance ?? (instance = new CheeseDecorator());

        public override IPizza Decorate(IPizza pizza, Enum type,  int quantity)
        {
            pizza.Additions.Add(new BlueCheese(quantity));

            return pizza;
        }
    }
}
