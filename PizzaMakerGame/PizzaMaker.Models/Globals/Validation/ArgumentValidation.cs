namespace PizzaMaker.Models.Globals.Validation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ArgumentValidation
    {
        public static void NegativeValueValidation(int data, string target)
        {
            if (data < 0)
            {
                throw new ArgumentException(target + "cannot have a negative value!");
            }
        }
    }
}
