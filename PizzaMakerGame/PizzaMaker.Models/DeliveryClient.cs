namespace PizzaMaker.Models
{
    public struct DeliveryClient
    {
        private string name;
        private string address;
        private string phone;

        public DeliveryClient(string name, string address, string phoneNumber)
        {
            // TO DO - Validation of clients Name not to be null or > certain symbols, 
            // address not to be less than 15 symbols, phone ...
            this.name = name;
            this.address = address;
            this.phone = phoneNumber;
        }

        public override string ToString()
        {
            return string.Format(
                "Delivery to client {0} at {1}. Phone: {2}", this.name, this.address, this.phone);
        }
    }
}
