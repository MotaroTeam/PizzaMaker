namespace ConsoleRenderer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using PizzaMaker.Models.Enums;
    using PizzaMaker.Models.Globals;
    using PizzaMaker.Models.Interfaces;

    public static class AdditionMenu
    {
        public static void PrintMenu(List<IAdditive> pizzaAdditions)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(GlobalConstants.SmallSeparator);

            foreach (var addition in pizzaAdditions)
            {
                builder.AppendLine(string.Format("= {0} ", addition.GetType().Name));
            }

            builder.AppendLine(GlobalConstants.SmallSeparator);

            Console.WriteLine(builder.ToString());
        }

    }
}
