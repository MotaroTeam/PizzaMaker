namespace PizzaMaker.Logic.Decorators
{
    using System;
    using Models.Additions.Vegetables;
    using Models.BaseClasses;
    using Models.Enums.ProductType;
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
            var vegetable = this.VegetableFactory((VegetablesType)type, quantity);

            pizza.Additions.Add(vegetable);

            return pizza;
        }

        private IAdditive VegetableFactory(VegetablesType sauce, int quantity)
        {
            switch (sauce)
            {
                case VegetablesType.Broccoli:
                    return new Broccoli(quantity);
                case VegetablesType.Mushroom:
                    return new Mushroom(quantity);
                case VegetablesType.Olive:
                    return new Olive(quantity);
                case VegetablesType.Onion:
                    return new Onion(quantity);
                case VegetablesType.Pepper:
                    return new Pepper(quantity);
                case VegetablesType.Tomato:
                    return new Tomato(quantity);
                default:
                    throw new NullReferenceException("No such vegetable");
            }
        }
    }
}
