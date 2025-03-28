using Multishop.Catalog.Dtos.ProductDetailDtos;

namespace Multishop.Catalog.Services.ProductDetailServices
{
    public interface IProductDetailService
    {
        Task CreateProductDetailAsync(CreateProductDetailDto createProductDetailDto);
        Task UpdateProductDetailAsync(UpdateProductDetailDto updateProductDetailDto);
        Task<GetByIdProductDetailDto> GetByIdProductDetailAsync(string id);
        Task<List<ResultProductDetailDto>> GetAllProductDetailAsync();
        Task DeleteProductDetailAsync(string id);
    }
}
