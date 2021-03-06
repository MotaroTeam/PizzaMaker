﻿namespace PizzaMaker.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Common;
    using Decorators;
    using Models;
    using Models.Enums;
    using Models.Enums.ProductType;
    using Models.Interfaces;
    using SizeType = global::PizzaMaker.Models.Enums.SizeType;

    public class PizzaMaker : IMaker
    {
        private IRenderer render;
        private ICollection<IPizza> pizzas; 

        public PizzaMaker(IRenderer render)
        {
            this.PizzaFinished += this.PizzaMaker_PizzaFinished;
            this.Name = GlobalConstants.MakerName;
            this.render = render;
            this.pizzas = new List<IPizza>();
            this.Balance = GlobalConstants.DefaultBalance;
        }

        private event EventHandler PizzaFinished;

        public ICollection<IPizza> Pizzas
        {
            get
            {
                return this.pizzas;
            }

            set
            {
                this.pizzas = value;
            }
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
            this.Balance += pizza.Price;
            this.pizzas.Remove(pizza);
        }

        public IPizza Create(string name, ForType usage, SizeType size)
        {
            var pizza = new Pizza(name, usage, size);
            if (usage == ForType.Delivery)
            {
                this.Render.PrintMenu(pizza);
                var client = this.Render.GetClientDetails();

                this.Deliver(client);
            }

            this.Render.PrintMenu(pizza);

            int additionCategory = this.Render.InputFromEnum<ProductTypes>("Choose category: ");

            while (additionCategory != 0)
            {
                int addition = 0;

                this.Render.PrintMenu(pizza);

                switch (additionCategory)
                {
                    case 1:
                        addition = this.Render.InputFromEnum<CheeseType>("Choose additions to add: ", ConsoleColor.Blue);
                        var cheeseDecorator = CheeseDecorator.Instance;
                        cheeseDecorator.Decorate(pizza, (CheeseType)addition, 1);
                        break;
                    case 2:
                        addition = this.Render.InputFromEnum<FruitType>("Choose additions to add: ", ConsoleColor.Cyan);
                        var fruitDecorator = FruitDecorator.Instance;
                        fruitDecorator.Decorate(pizza, (FruitType)addition, 1);
                        break;
                    case 3:
                        addition = this.Render.InputFromEnum<MeatType>("Choose additions to add: ", ConsoleColor.Yellow);
                        var meatDecorator = MeatDecorator.Instance;
                        meatDecorator.Decorate(pizza, (MeatType)addition, 1);
                        break;
                    case 4:
                        addition = this.Render.InputFromEnum<SauceType>("Choose additions to add: ", ConsoleColor.DarkGreen);
                        var sauceDecorator = SauceDecorator.Instance;
                        sauceDecorator.Decorate(pizza, (SauceType)addition, 1);
                        break;
                    case 5:
                        addition = this.Render.InputFromEnum<SpiceType>("Choose additions to add: ", ConsoleColor.DarkMagenta);
                        var spiceDecorator = SpiceDecorator.Instance;
                        spiceDecorator.Decorate(pizza, (SpiceType)addition, 1);
                        break;
                    case 6:
                        addition = this.Render.InputFromEnum<VegetablesType>("Choose additions to add: ", ConsoleColor.DarkYellow);
                        var vegetableDecorator = VegetableDecorator.Instance;
                        vegetableDecorator.Decorate(pizza, (VegetablesType)addition, 1);
                        break;
                    default:
                        throw new ArgumentException("No such category!");
                }

                this.Render.PrintMenu(pizza);

                additionCategory = this.Render.InputFromEnum<ProductTypes>("Choose category: ");
            }

            this.PizzaFinished?.Invoke(null, EventArgs.Empty);
            this.pizzas.Add(pizza);

            return pizza;
        }

        public void Deliver(DeliveryClient client)
        {
            Console.WriteLine(client.ToString());
        }

        private void PizzaMaker_PizzaFinished(object sender, EventArgs e)
        {
            MessageBox.Show("Pizza ready");
        }
    }
}
