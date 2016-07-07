namespace PizzaMaker.Logic.Decorators
{
    using System;
    using Models.BaseClasses;
    using Models.Interfaces;
    using PizzaMaker.Models;
    
    public class SausageDecorator : Decorator
    {
        private static SausageDecorator instance;

        private SausageDecorator() 
        {
        }

        public static SausageDecorator Instance => instance ?? (instance = new SausageDecorator());

        public override IPizza Decorate(IPizza pizza, Enum type, int quantity)
        {
            pizza.Additions.Add(new Sausage(quantity));

            return pizza;
        }
    }
}
