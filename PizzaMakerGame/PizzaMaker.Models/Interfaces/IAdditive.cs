namespace PizzaMaker.Models.Interfaces
{
    public interface IAdditive
    {
        string Name { get; }

        decimal Price { get; }

        int Quantity { get; set; }
    }
}