namespace PizzaMaker.Models.Globals.Validation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AdditionOverload : Exception
    {
        public AdditionOverload(string message)
        : base(message)
        {
        }

        public AdditionOverload(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
