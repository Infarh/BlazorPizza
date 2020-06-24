using System.Collections.Generic;
using System.Linq;
using BlazorPizza.Domain.Entities.Base.Interfaces;

namespace BlazorPizza.Interfaces.Stores
{
    public interface IStore<T> : IEnumerable<T> where T : IEntity
    {
        T this[int Id] => Get(Id);

        IEnumerable<T> Get();

        T Get(int Id) => Get().FirstOrDefault(i => i.Id == Id);

        int Add(T item);

        void Update(T item);

        T Delete(int id);
    }
}
