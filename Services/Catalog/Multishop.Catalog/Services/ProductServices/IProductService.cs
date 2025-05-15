using Multishop.Catalog.Dtos.ProductDtos;

namespace Multishop.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task<GetByIdProductDto> GetByIdProductAsync(string id);
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task DeleteProductAsync(string id);
        Task<List<ResultProductWithCategoryDto>> GetProductsWithCategoryAsync();
    }
}
