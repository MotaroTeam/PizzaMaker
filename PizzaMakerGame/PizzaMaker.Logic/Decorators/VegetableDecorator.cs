namespace PizzaMaker.Logic.Decorators
{
    using System;
    using Models.Additions.Vegetables;
    using Models.BaseClasses;
    using Models.Enums;
    using Models.Interfaces;

    public class VegetableDecorator : Decorator
    {
        private static VegetableDecorator instance;

        private VegetableDecorator()
        {
        }

        public static VegetableDecorator Instance => instance ?? (instance = new VegetableDecorator());

        public override IPizza Decorate(IPizza pizza, Enum type, int quantity)
        {
            var vegetable = this.VegetableFactory((Vegetables)type, quantity);

            pizza.Additions.Add(vegetable);

            return pizza;
        }

        private IAdditive VegetableFactory(Vegetables sauce, int quantity)
        {
            switch (sauce)
            {
                case Vegetables.Broccoli:
                    return new Broccoli(quantity);
                case Vegetables.Mushroom:
                    return new Mushroom(quantity);
                case Vegetables.Olive:
                    return new Olive(quantity);
                case Vegetables.Onion:
                    return new Onion(quantity);
                case Vegetables.Pepper:
                    return new Pepper(quantity);
                case Vegetables.Tomatoe:
                    return new Tomatoe(quantity);
                default:
                    throw new NullReferenceException("No such vegetable");
            }
        }
    }
}
