namespace PizzaMaker
{
    using System;
    using ConsoleRenderer;
    using Logic.Decorators;
    using Models;
    using Models.Enums;
    using Models.Enums.ProductType;
    using Models.Globals;

    public static class Startup
    {
        public static void Main()
        {
            // TODO: Optionally change buffer/window size
            var renderer = new ConsoleRenderer();

            var pizzaName = renderer.Input("Pizza name");

            var forWhere = renderer.InputFromEnum<ForType>("Choose for: ");

            var size = renderer.InputFromEnum<SizeType>("Choose size: ");

            var pizza = new Pizza(pizzaName, (ForType)forWhere, (SizeType)size);

            Console.Clear();
            AdditionMenu.PrintMenu(pizza.Additions);

            int additionCategory = renderer.InputFromEnum<ProductTypes>("Choose category: ");

            while (additionCategory != 0)
            {
                int addition = 0;

                Console.Clear();
                AdditionMenu.PrintMenu(pizza.Additions);

                // TODO : Implement multiple choice of additions at once
                switch (additionCategory)
                {
                    case 1:
                        addition = renderer.InputFromEnum<CheeseType>("Choose additions to add: ");
                        var cheeseDecorator = CheeseDecorator.Instance;
                        cheeseDecorator.Decorate(pizza, (CheeseType)addition, 1);
                        break;
                    case 2:
                        addition = renderer.InputFromEnum<FruitType>("Choose additions to add: ");
                        var fruitDecorator = FruitDecorator.Instance;
                        fruitDecorator.Decorate(pizza, (FruitType)addition, 1);
                        break;
                    case 3:
                        addition = renderer.InputFromEnum<MeatType>("Choose additions to add: ");
                        var meatDecorator = MeatDecorator.Instance;
                        meatDecorator.Decorate(pizza, (MeatType)addition, 1);
                        break;
                    case 4:
                        addition = renderer.InputFromEnum<SauceType>("Choose additions to add: ");
                        var sauceDecorator = SauceDecorator.Instance;
                        sauceDecorator.Decorate(pizza, (SauceType)addition, 1);
                        break;
                    case 5:
                        addition = renderer.InputFromEnum<SpiceType>("Choose additions to add: ");
                        var spiceDecorator = SpiceDecorator.Instance;
                        spiceDecorator.Decorate(pizza, (SpiceType)addition, 1);
                        break;
                    case 6:
                        addition = renderer.InputFromEnum<VegetablesType>("Choose additions to add: ");
                        var vegetableDecorator = VegetableDecorator.Instance;
                        vegetableDecorator.Decorate(pizza, (VegetablesType)addition, 1);
                        break;
                    default:
                        throw new ArgumentException("No such category!");
                }

                Console.Clear();
                AdditionMenu.PrintMenu(pizza.Additions);

                additionCategory = renderer.InputFromEnum<ProductTypes>("Choose category: ");
            }

            // TODO: Lower the price of additions
            renderer.RenderPizza(pizza);

            Console.ReadKey();
        }
    }
}