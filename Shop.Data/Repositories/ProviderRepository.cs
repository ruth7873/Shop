using Microsoft.EntityFrameworkCore;
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
        public async Task<IEnumerable<Provider>> GetProvidersAsync()
        {
            return await _context.Providers.ToListAsync();
        }
        public async Task<Provider> GetProviderByIdAsync(int id)
        {
            return await _context.Providers.FindAsync(id);
        }
        public async Task<Provider> AddProviderAsync(Provider provider)
        {
            _context.Providers.Add(provider);
            await _context.SaveChangesAsync();
            return provider;
        }
        public async Task<Provider> UpdateProviderAsync(int id, Provider provider)
        {
            Provider provider1 = _context.Providers.Find(id);
            if (provider1 != null)
            {
                provider1.Name = provider.Name;
                provider1.Debt = provider.Debt;
                provider1.City = provider.City;

            }
            await _context.SaveChangesAsync();
            return provider1;
        }
        public async void DeleteProviderAsync(int id)
        {
            if (_context.Providers.Find(id) != null)
            {
                _context.Providers.Remove(_context.Providers.Find(id));
                _context.SaveChangesAsync();
            }
        }
    }
}
