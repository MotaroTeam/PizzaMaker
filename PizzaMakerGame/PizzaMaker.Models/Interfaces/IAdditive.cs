namespace PizzaMaker.Models.Interfaces
{
    public interface IAdditive
    {
        string Name { get; }

        decimal Price { get; }

        int Calories { get; }

        int Quantity { get; }

        bool IsVegetarian { get; }
    }
}