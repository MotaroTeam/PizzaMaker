namespace ConsoleRenderer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using PizzaMaker.Models.Globals;
    using PizzaMaker.Models.Interfaces;

    public static class AdditionMenu
    {
        private static ICollection<IAdditive> additions = new List<IAdditive>();

        public static void PrintMenu(ICollection<IAdditive> additionsList)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(GlobalConstants.SmallSeparator);

            foreach (var addition in additionsList)
            {
                builder.AppendLine(string.Format("= {0} ", addition.GetType().Name));
            }

            builder.AppendLine(GlobalConstants.SmallSeparator);

            Console.WriteLine(builder.ToString());
        }

        public static void AddToList(IAdditive addition)
        {
            additions.Add(addition);
        }
    }
}
