using System.ComponentModel.DataAnnotations;

namespace BlazorPizza.Domain.Entities.Base.Interfaces
{
    public interface INamedEntity : IEntity
    {
        [Required]
        string Name { get; set; }
    }
}