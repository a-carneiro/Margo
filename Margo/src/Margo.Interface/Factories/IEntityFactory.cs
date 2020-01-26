using Margo.Domain.Entities.BaseModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Margo.Interface.Factories
{
    public interface IEntityFactory<T> where T : BaseEntity
    {
        Task<bool> CreateAsync(T entity);
        Task<T> GetAsync(int id);
        Task<bool> RemoveAsync(int id);
        Task<ICollection<T>> GetAllAsync();
    }
}
