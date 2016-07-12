namespace Common.Validation
{
    using System;

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
