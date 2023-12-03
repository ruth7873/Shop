using Shop.Core.Entities;


namespace Shop.Core.Repositories
{
    public interface IProviderRepository
    {
        IEnumerable<Provider> GetProviders();        
        Provider GetProviderById(int id);
        void AddProvider(Provider provider);
        void UpdateProvider(int id,Provider provider);
        void DeleteProvider(int id);
    }
}
