using Multishop.Catalog.Dtos.CategoryDtos;

namespace Multishop.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task<GetByIdCategoryDto> GetByIdCategoryAsync(GetByIdCategoryDto getByIdCategoryDto);
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task DeleteCategoryAsync(string id);
    }
}
