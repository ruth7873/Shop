using AutoMapper;
using Shop.API.Model;
using Shop.Core.Entities;

namespace Shop.API.Mapping
{
    public class ApiMappingProfile:Profile
    {
        public ApiMappingProfile()
        {
            CreateMap <OrderPostModel,Order> ();
            CreateMap <ProductOrderPostModel,ProductOrder> ();
        }
    }
}
