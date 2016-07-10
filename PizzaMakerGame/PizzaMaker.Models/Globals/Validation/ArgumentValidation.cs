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

        public static bool ClientNameValidation(string name)
        {
            if (name == null || name.Length > 20)
            {
                throw new ArgumentException("Name cannot be left empty/cannot have length bigger than 20 symbols!");
            }

            return true;
        }

        public static void ClientAdressValidation(string adress)
        {
            if (adress == null || adress.Length < 15)
            {
                throw new ArgumentException("Aress is obligatory to fill/Length cannot be less than 15 symbols!");
            }
        }

        public static void ClientPhoneValidation(string phone)
        {
            if (phone.Any(x => !char.IsDigit(x)) || phone.Length > 12)
            {
                throw new ArgumentException("Allowed length : 12 symbols / Only digits allowed!");
            }
        }
    }
}
