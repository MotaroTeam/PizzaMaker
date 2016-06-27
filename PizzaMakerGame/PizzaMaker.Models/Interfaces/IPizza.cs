namespace PizzaMaker.Models.Interfaces
{
    using System.Collections.Generic;
    using Enums;

    public interface IPizza
    {
        string Name { get; }

        Size Size { get; }

        For For { get; set; }

        ICollection<IAdditive> Additions { get; }
    }
}
