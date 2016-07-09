namespace PizzaMaker.Logic.Decorators
{
    using System;
    using Models.Additions.Fruits;
    using Models.BaseClasses;
    using Models.Enums.ProductType;
    using Models.Interfaces;

    public class FruitDecorator : Decorator
    {
        private static FruitDecorator instance;

        private FruitDecorator()
        {
        }

        public static FruitDecorator Instance => instance ?? (instance = new FruitDecorator());

        public override IPizza Decorate(IPizza pizza, Enum type, int quantity)
        {
            var fruit = this.FruitFactory((FruitType)type, quantity);

            pizza.Additions.Add(fruit);

            return pizza;
        }

        private IAdditive FruitFactory(FruitType fruit, int quantity)
        {
            switch (fruit)
            {
                case FruitType.Apple:
                    return new Apple(quantity);
                case FruitType.Pineapple:
                    return new Pineapple(quantity);
                case FruitType.Mango:
                    return new Mango(quantity);
                case FruitType.Avocado:
                    return new Avocado(quantity);
                default:
                    throw new NullReferenceException("No such fruit avaliable");
            }
        }
    }
}