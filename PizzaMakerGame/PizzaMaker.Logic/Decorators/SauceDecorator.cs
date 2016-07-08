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
            var sauce = this.SauceFactory((Sauces)type, quantity);

            pizza.Additions.Add(sauce);

            return pizza;
        }

        private IAdditive SauceFactory(Sauces sauce, int quantity)
        {
            switch (sauce)
            {
                case Sauces.Alfredo:
                    return new Alfredo(quantity);
                case Sauces.Chily:
                    return new Chily(quantity);
                case Sauces.GarlicSauce:
                    return new GarlicSauce(quantity);
                case Sauces.Ketchup:
                    return new Ketchup(quantity);
                case Sauces.Marinara:
                    return new Marinara(quantity);
                case Sauces.Pesto:
                    return new Pesto(quantity);
                case Sauces.Ranch:
                    return new Ranch(quantity);
                default:
                    throw new NullReferenceException("No such sauce");
            }
        }
    }
}
