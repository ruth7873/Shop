using Shop.Core.Entities;
using Shop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Repositories
{
    public class ProviderRepository : IProviderRepository
    {
        private readonly DataContext _context;
        public ProviderRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public IEnumerable<Provider> GetProviders()
        {
            return _context.Providers;
        }
        public Provider GetProviderById(int id)
        {
            return _context.Providers.Find(id);
        }
        public Provider AddProvider(Provider provider)
        {
            _context.Providers.Add(provider);
            _context.SaveChanges();
            return provider;
        }
        public Provider UpdateProvider(int id, Provider provider)
        {
            Provider provider1 = _context.Providers.Find(id);
            if (provider1 != null)
            {
                provider1.Name = provider.Name;
                provider1.Debt = provider.Debt;
                provider1.City = provider.City;
                
            }
            _context.SaveChanges();
            return provider1;
        }
        public void DeleteProvider(int id)
        {
            _context.Providers.Remove(_context.Providers.Find(id));
            _context.SaveChanges();
        }
    }
}
