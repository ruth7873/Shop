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
        public async Task<IEnumerable<Provider>> GetProvidersAsync()
        {
           return await _providerRepository.GetProvidersAsync();
        }
        public async Task<Provider> GetProviderByIdAsync(int id)
        {
            return await _providerRepository.GetProviderByIdAsync(id);
        }
        public async Task<Provider> AddProviderAsync(Provider provider)
        {
          return await _providerRepository.AddProviderAsync(provider);
        }
        public async Task<Provider> UpdateProviderAsync(int id, Provider provider)
        {
           return await _providerRepository.UpdateProviderAsync(id, provider);
            
        }
        public void DeleteProviderAsync(int id)
        {
          _providerRepository.DeleteProviderAsync(id);
        }
    }
}
