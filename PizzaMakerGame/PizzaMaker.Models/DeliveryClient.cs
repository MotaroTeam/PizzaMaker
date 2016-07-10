namespace PizzaMaker.Models
{
    using Globals.Validation;

    public struct DeliveryClient
    {
        private string name;
        private string address;
        private string phone;

        public DeliveryClient(string name, string address, string phoneNumber)
        {
            this.name = name;
            this.address = address;
            this.phone = phoneNumber;
        }

        public override string ToString()
        {
            return string.Format(
                "Delivery to client - {0} | Adress: {1} | Phone: {2}", this.name, this.address, this.phone);
        }
    }
}

