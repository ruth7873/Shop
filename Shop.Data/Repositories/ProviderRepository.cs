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
            return _context.Providers.ToList().Find(p => p.Id == id);
        }
        public void AddProvider(Provider provider)
        {
            _context.Providers.Add(provider);
        }
        public void UpdateProvider(int id, Provider provider)
        {
            Provider provider1 = _context.Providers.ToList().Find(p => p.Id == id);
            if (provider1 != null)
                _context.Providers.Remove(provider1);
            _context.Providers.Add(provider);
        }
        public void DeleteProvider(int id)
        {
            _context.Providers.Remove(_context.Providers.ToList().Find(p => p.Id == id));
        }
    }
}
