namespace PizzaMaker.Logic.Decorators
{
    using System;
    using Models.Additions.Meat;
    using Models.BaseClasses;
    using Models.Enums.ProductType;
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
            var meat = this.MeatFactory((MeatType)type, quantity);

            pizza.Additions.Add(meat);
            
            return pizza;
        }

        private IAdditive MeatFactory(MeatType meat, int quantity)
        {
            switch (meat)
            {
                case MeatType.Beacon:
                    return new Bacon(quantity);
                case MeatType.Beef:
                    return new Beef(quantity);
                case MeatType.Chicken:
                    return new Chicken(quantity);
                case MeatType.Ham:
                    return new Ham(quantity);
                case MeatType.Pepperoni:
                    return new Pepperoni(quantity);
                case MeatType.Sausage:
                    return new Sausage(quantity);
                default:
                    throw new NullReferenceException("No such meat");
            }
        }
    }
}
