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
        Provider AddProvider(Provider provider);
        Provider UpdateProvider(int id, Provider provider);
        void DeleteProvider(int id);
    }
}
