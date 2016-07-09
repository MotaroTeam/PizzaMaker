namespace PizzaMaker.Models.Interfaces
{
    using System.Collections.Generic;
    using Enums;

    public interface IPizza
    {
        string Name { get; }

        SizeType Size { get; }

        decimal Price { get; }

        ForType For { get; set; }

        ICollection<IAdditive> Additions { get; }
    }
}
