namespace PizzaMaker.Logic
{
    using System;
    using System.Collections.Generic;
    using Decorators;
    using Models;
    using Models.Enums;
    using Models.Enums.ProductType;
    using Models.Interfaces;

    public class PizzaMaker : IMaker
    {
        private IRenderer render;

        public PizzaMaker(string name, IRenderer render)
        {
            this.Name = name;
            this.render = render;
        }

        public IRenderer Render => this.render;

        public string Name { get; set; }

        public decimal Balance { get; set; }

        public ICollection<IDeliverable> PizzasForDelivery { get; set; }

        public void Buy(IAdditive resource)
        {
            throw new System.NotImplementedException();
        }

        public void Sell(IPizza pizza)
        {
            throw new System.NotImplementedException();
        }

        public IPizza Create(string name, ForType usage, SizeType size)
        {
            var pizza = new Pizza(name, usage, size);

            //Console.Clear();
            //AdditionMenu.PrintMenu(pizza.Additions);

            int additionCategory = this.Render.InputFromEnum<ProductTypes>("Choose category: ");

            while (additionCategory != 0)
            {
                int addition = 0;

                //Console.Clear();
                //AdditionMenu.PrintMenu(pizza.Additions);

                switch (additionCategory)
                {
                    case 1:
                        addition = this.Render.InputFromEnum<CheeseType>("Choose additions to add: ");
                        var cheeseDecorator = CheeseDecorator.Instance;
                        cheeseDecorator.Decorate(pizza, (CheeseType)addition, 1);
                        break;
                    case 2:
                        addition = this.Render.InputFromEnum<FruitType>("Choose additions to add: ");
                        var fruitDecorator = FruitDecorator.Instance;
                        fruitDecorator.Decorate(pizza, (FruitType)addition, 1);
                        break;
                    case 3:
                        addition = this.Render.InputFromEnum<MeatType>("Choose additions to add: ");
                        var meatDecorator = MeatDecorator.Instance;
                        meatDecorator.Decorate(pizza, (MeatType)addition, 1);
                        break;
                    case 4:
                        addition = this.Render.InputFromEnum<SauceType>("Choose additions to add: ");
                        var sauceDecorator = SauceDecorator.Instance;
                        sauceDecorator.Decorate(pizza, (SauceType)addition, 1);
                        break;
                    case 5:
                        addition = this.Render.InputFromEnum<SpiceType>("Choose additions to add: ");
                        var spiceDecorator = SpiceDecorator.Instance;
                        spiceDecorator.Decorate(pizza, (SpiceType)addition, 1);
                        break;
                    case 6:
                        addition = this.Render.InputFromEnum<VegetablesType>("Choose additions to add: ");
                        var vegetableDecorator = VegetableDecorator.Instance;
                        vegetableDecorator.Decorate(pizza, (VegetablesType)addition, 1);
                        break;
                    default:
                        throw new ArgumentException("No such category!");
                }

                //Console.Clear();
                //AdditionMenu.PrintMenu(pizza.Additions);

                additionCategory = this.Render.InputFromEnum<ProductTypes>("Choose category: ");
            }

            return pizza;
        }

        public void Deliver(DeliveryClient client)
        {
            Console.WriteLine(client.ToString());
        }
    }
}
