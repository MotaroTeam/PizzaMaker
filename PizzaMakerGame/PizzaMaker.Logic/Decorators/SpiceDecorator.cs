namespace PizzaMaker.Logic.Decorators
{
    using System;
    using Models.Additions.Spices;
    using Models.BaseClasses;
    using Models.Enums.ProductType;
    using Models.Interfaces;

    public class SpiceDecorator : Decorator
    {
        private static SpiceDecorator instance;

        private SpiceDecorator()
        {
        }

        public static SpiceDecorator Instance => instance ?? (instance = new SpiceDecorator());

        public override IPizza Decorate(IPizza pizza, Enum type, int quantity)
        {
            var spice = this.SpiceFactory((SpiceType)type, quantity);

            pizza.Additions.Add(spice);

            return pizza;
        }

        private IAdditive SpiceFactory(SpiceType spice, int quantity)
        {
            switch (spice)
            {
                case SpiceType.Savory:
                    return new Savory(quantity);
                case SpiceType.Basil:
                    return new Basil(quantity);
                case SpiceType.Oregano:
                    return new Oregano(quantity);
                case SpiceType.Rosemary:
                    return new Rosemary(quantity);
                default:
                    throw new NullReferenceException("No such spice avaliable");
            }
        }
    }
}
