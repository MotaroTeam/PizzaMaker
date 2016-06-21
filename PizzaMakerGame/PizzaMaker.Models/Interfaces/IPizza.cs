namespace PizzaMaker.Models.Interfaces
{
    using System.Collections.Generic;
    using Enums;

    public interface IPizza
    {
        Size Size { get; }

        For For { get; set; }

        ICollection<IAdditives> Additions { get; } 
    }
}
