using AutoMapper;
using Shop.API.Model;
using Shop.Core.Entities;

namespace Shop.API.Mapping
{
    public class ApiMappingProfile:Profile
    {
        public ApiMappingProfile()
        {
            CreateMap <OrderPostModel,Order> ().ReverseMap();
            CreateMap <ProductOrderPostModel,ProductOrder> ().ReverseMap();
            CreateMap <ProductPostModel,Product> ().ReverseMap();
            CreateMap <ProviderPostModel,Provider> ().ReverseMap();

        }
    }
}
