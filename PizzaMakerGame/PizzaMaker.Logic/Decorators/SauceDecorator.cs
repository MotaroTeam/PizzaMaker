namespace PizzaMaker.Logic.Decorators
{
    using System;
    using PizzaMaker.Models.Additions.Sauces;
    using PizzaMaker.Models.BaseClasses;
    using PizzaMaker.Models.Enums;
    using PizzaMaker.Models.Interfaces;

    public class SauceDecorator : Decorator
    {
        private static SauceDecorator instance;

        private SauceDecorator()
        {
        }

        public static SauceDecorator Instance => instance ?? (instance = new SauceDecorator());
        
        public override IPizza Decorate(IPizza pizza, Enum type, int quantity)
        {
            switch ((Sauces)type)
            {
                case Sauces.Alfredo:
                    pizza.Additions.Add(new Alfredo(quantity));
                    return pizza;
                case Sauces.Chily:
                    pizza.Additions.Add(new Chily(quantity));
                    return pizza;
                case Sauces.GarlicSauce:
                    pizza.Additions.Add(new GarlicSauce(quantity));
                    return pizza;
                case Sauces.Ketchup:
                    pizza.Additions.Add(new Ketchup(quantity));
                    return pizza;
                case Sauces.Marinara:
                    pizza.Additions.Add(new Marinara(quantity));
                    return pizza;
                case Sauces.Pesto:
                    pizza.Additions.Add(new Pesto(quantity));
                    return pizza;
                case Sauces.Ranch:
                    pizza.Additions.Add(new Ranch(quantity));
                    return pizza;
                default:
                    return pizza;
            }
        }
    }
}
