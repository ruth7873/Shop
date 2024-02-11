using Shop.Core.Entities;


namespace Shop.Core.Repositories
{
    public interface IProviderRepository
    {
        Task<IEnumerable<Provider>> GetProvidersAsync();
        Task<Provider> GetProviderByIdAsync(int id);
        Task<Provider> AddProviderAsync(Provider provider);
        Task<Provider> UpdateProviderAsync(int id, Provider provider);
        void DeleteProviderAsync(int id);
    }
}
