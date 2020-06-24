using BlazorPizza.Domain.Entities.Base.Interfaces;

namespace BlazorPizza.Domain.Entities.Base
{
    public abstract class NamedEntity : Entity, INamedEntity
    {
        public string Name { get; set; }

        protected NamedEntity() { }

        protected NamedEntity(int Id) : base(Id) { }

        protected NamedEntity(int Id, string Name) : base(Id) => this.Name = Name;
    }
}
