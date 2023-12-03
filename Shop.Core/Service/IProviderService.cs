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
        IEnumerable<Provider> GetProviders();
        Provider GetProviderById(int id);
        void AddProvider(Provider provider);
        void UpdateProvider(int id, Provider provider);
        void DeleteProvider(int id);
    }
}
