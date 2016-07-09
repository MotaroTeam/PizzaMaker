﻿namespace PizzaMaker
{
    using System;
    using ConsoleRenderer;
    using Logic.Decorators;
    using Models;
    using Models.Enums;
    using Models.Enums.ProductType;

    public static class Startup
    {
        public static void Main()
        {
            var renderer = new ConsoleRenderer();

            var pizzaName = renderer.Input("Pizza name");

            var forWhere = renderer.InputFromEnum<ForType>("Choose ....");

            var pizza = new Pizza(pizzaName, (ForType)forWhere, SizeType.Large);

            var sauceDecorator = SauceDecorator.Instance;

            sauceDecorator.Decorate(pizza, SauceType.Alfredo, 1);

            renderer.RenderPizza(pizza);

            Console.ReadKey();
        }
    }
}