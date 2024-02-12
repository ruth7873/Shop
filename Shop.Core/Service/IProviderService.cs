using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service
{
    public interface IProviderService
    {
        Task<IEnumerable<Provider>> GetProvidersAsync();
        Task<Provider> GetProviderByIdAsync(int id);
        Task<Provider> AddProviderAsync(Provider provider);
        Task<Provider> UpdateProviderAsync(int id, Provider provider);
        void DeleteProviderAsync(int id);
    }
}
