namespace PizzaMaker.Models.Interfaces
{
    public interface IAdditives
    {
        string Name { get; }

        int Quantity { get; set; }
    }
}