using Shop.Core.Entities;
using Shop.Core.Repositories;
using Shop.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service
{
    public class ProviderService : IProviderService
    {
        private readonly IProviderRepository _providerRepository;
        public ProviderService(IProviderRepository providerRepository)
        {
            _providerRepository = providerRepository;
        }
        public IEnumerable<Provider> GetProviders()
        {
           return _providerRepository.GetProviders();
        }
        public Provider GetProviderById(int id)
        {
            return _providerRepository.GetProviderById(id);
        }
        public Provider AddProvider(Provider provider)
        {
          return _providerRepository.AddProvider(provider);
        }
        public Provider UpdateProvider(int id, Provider provider)
        {
           return _providerRepository.UpdateProvider(id, provider);
            
        }
        public void DeleteProvider(int id)
        {
          _providerRepository.DeleteProvider(id);
        }
    }
}
