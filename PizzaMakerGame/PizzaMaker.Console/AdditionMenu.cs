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
        public static void PrintMenu(IList<IAdditive> pizzaAdditions)
        {
            Console.SetCursorPosition(40, 0);
            Console.WriteLine("Ingridients choosen: ");
            Console.SetCursorPosition(40, 1);
            Console.WriteLine(GlobalConstants.SmallSeparator);

            // TODO: Add ingridient characteristics from here
            for (int i = 0; i < pizzaAdditions.Count; i++)
            {
                Console.SetCursorPosition(40, i + 2);
                Console.WriteLine(string.Format(" -> {0}(Grams:{1}, Cal:{2})".PadRight(25, ' '), pizzaAdditions[i].GetType().Name, 
                    pizzaAdditions[i].Quantity, pizzaAdditions[i].Calories));
            }

            Console.SetCursorPosition(40, 2 + pizzaAdditions.Count + 1);
            Console.WriteLine(GlobalConstants.SmallSeparator);
        }
    }
}
