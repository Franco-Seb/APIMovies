using APIMovies.DAL.Models;
using APIMovies.DAL.Models.Dtos;

namespace APIMovies.Services.IServices
{
    public interface ICategoryService
    {
        Task<ICollection<CategoryDto>> GetCategoriesAsync();
        Task<CategoryDto> GetCategoryAsync(int id);
        Task<bool> CategoryExistsByIdAsync(int id);
        Task<bool> CategoryExistsByNameAsync(string name);
        Task<CategoryDto> CreateCategoryAsync(CategoryCreateDto categoryDto);
        Task<CategoryDto> UpdateCategoryAsync(int id, Category CategoryDto);
        Task<bool> DeleteCategoryAsync(int id);
    }
}
