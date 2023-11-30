using Shop.Core.Repositories;
using Shop_ruthHershler;
using Shop_ruthHershler.Entities;
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

        public ProviderRepository(DataContext context)
        {
            _context = context;
        }

        public List<Provider> GetProviders()
        {
            return _context.Providers;
        }
    }
}
