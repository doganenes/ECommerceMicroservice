using Multishop.Catalog.Dtos.ProductImageDtos;

namespace Multishop.Catalog.Services.ProductImageServices
{
    public interface IProductImageService
    {
        Task CreateProductImageAsync(CreateProductImageDto createProductImageDto);
        Task UpdateProductImageAsync(UpdateProductImageDto updateProductImageDto);
        Task<GetByIdProductImageDto> GetByIdProductImageAsync(string id);
        Task<List<ResultProductImageDto>> GetAllProductImageAsync();
        Task DeleteProductImageAsync(string id);
    }
}
