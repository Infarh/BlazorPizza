using BlazorPizza.Domain.Entities.Base.Interfaces;

namespace BlazorPizza.Domain.Entities.Base
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }

        protected Entity() { }

        protected Entity(int Id) => this.Id = Id;
    }
}
