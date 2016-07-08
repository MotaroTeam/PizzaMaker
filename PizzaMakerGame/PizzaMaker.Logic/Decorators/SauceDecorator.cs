namespace PizzaMaker.Logic.Decorators
{
    using System;
    using Models.Enums.ProductType;
    using PizzaMaker.Models.Additions.Sauces;
    using PizzaMaker.Models.BaseClasses;
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
            var sauce = this.SauceFactory((SauceType)type, quantity);

            pizza.Additions.Add(sauce);

            return pizza;
        }

        private IAdditive SauceFactory(SauceType sauce, int quantity)
        {
            switch (sauce)
            {
                case SauceType.Alfredo:
                    return new Alfredo(quantity);
                case SauceType.Chily:
                    return new Chily(quantity);
                case SauceType.GarlicSauce:
                    return new GarlicSauce(quantity);
                case SauceType.Ketchup:
                    return new Ketchup(quantity);
                case SauceType.Marinara:
                    return new Marinara(quantity);
                case SauceType.Pesto:
                    return new Pesto(quantity);
                case SauceType.Ranch:
                    return new Ranch(quantity);
                default:
                    throw new NullReferenceException("No such sauce");
            }
        }
    }
}
