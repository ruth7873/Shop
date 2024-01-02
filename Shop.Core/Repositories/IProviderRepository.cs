using Shop.Core.Entities;


namespace Shop.Core.Repositories
{
    public interface IProviderRepository
    {
        IEnumerable<Provider> GetProviders();        
        Provider GetProviderById(int id);
        Provider AddProvider(Provider provider);
        Provider UpdateProvider(int id,Provider provider);
        void DeleteProvider(int id);
    }
}
