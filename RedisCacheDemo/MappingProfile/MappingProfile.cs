using AutoMapper;
using RedisCacheDemo.Model;
using RedisCacheDemo.ViewModel;

namespace RedisCacheDemo.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>(); // Map Product entity to ProductDto
            CreateMap<ProductDto, Product>(); // Map ProductImage entity to ProductImageDto
                                                        // Add more CreateMap statements for other entity-DTO mappings if needed
        }
    }
}
