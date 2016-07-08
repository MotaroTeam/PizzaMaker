namespace PizzaMaker.Models.Interfaces
{
    public interface IDeliverable
    {
        DeliveryClient Client { get; set; }
    }
}