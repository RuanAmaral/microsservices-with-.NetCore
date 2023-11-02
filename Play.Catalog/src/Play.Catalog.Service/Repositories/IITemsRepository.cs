using Play.Catalog.Service.Entities;

namespace Play.Catalog.Service.Repositories
{
    public interface IITemsRepository
    {
        Task CreateAsync(Item entity);
        Task<IReadOnlyCollection<Item>> GetAllAsync();
        Task<Item> GetAsync(Guid id);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(Item entity);
    }


}