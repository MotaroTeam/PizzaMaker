namespace PizzaMaker.Logic.Decorators
{
    using System;
    using Models;
    using Models.Additions.Meat;
    using Models.BaseClasses;
    using Models.Interfaces;

    public class MeatDecorator : Decorator
    {
        private static MeatDecorator instance;

        private MeatDecorator() 
        {
        }

        public static MeatDecorator Instance => instance ?? (instance = new MeatDecorator());

        public override IPizza Decorate(IPizza pizza, Enum type, int quantity)
        {
            pizza.Additions.Add(new Sausage(quantity));

            return pizza;
        }
    }
}
