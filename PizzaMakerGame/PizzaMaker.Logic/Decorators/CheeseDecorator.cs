namespace PizzaMaker.Logic.Decorators
{
    using System;
    using Models.Enums.ProductType;
    using PizzaMaker.Models.Additions.Cheese;
    using PizzaMaker.Models.BaseClasses;
    using PizzaMaker.Models.Interfaces;

    public class CheeseDecorator : Decorator
    {
        private static CheeseDecorator instance;

        private CheeseDecorator()
        {
        }

        public static CheeseDecorator Instance => instance ?? (instance = new CheeseDecorator());

        public override IPizza Decorate(IPizza pizza, Enum type, int quantity)
        {
            var sauce = this.CheeseFactory((CheeseType)type, quantity);

            pizza.Additions.Add(sauce);

            return pizza;
        }

        private IAdditive CheeseFactory(CheeseType sauce, int quantity)
        {
            switch (sauce)
            {
                case CheeseType.BlueCheese:
                    return new BlueCheese(quantity);
                case CheeseType.Cheddar:
                    return new Cheddar(quantity);
                case CheeseType.Emmental:
                    return new Emmental(quantity);
                case CheeseType.Feta:
                    return new Feta(quantity);
                case CheeseType.Gouda:
                    return new Gouda(quantity);
                case CheeseType.Mozzarella:
                    return new Mozzarella(quantity);
                case CheeseType.SmokedCheese:
                    return new SmokedCheese(quantity);
                default:
                    throw new NullReferenceException("No such cheese");
            }
        }
    }
}
