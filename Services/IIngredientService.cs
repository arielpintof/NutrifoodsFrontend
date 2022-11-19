using NutrifoodsFrontend.Data.Dto;

namespace NutrifoodsFrontend.Services
{
    public interface IIngredientService
    {
        Task<ICollection<IngredientDto>?> GetAll();
        Task<IngredientDto?> FindByName(string name);
        Task<IngredientDto?> FindById(int id);
        Task<ICollection<IngredientDto>?> FindByPrimaryGroup(string name);
        Task<ICollection<IngredientDto>?> FindByPrimaryGroup(int id);
        Task<ICollection<IngredientDto>?> FindBySecondaryGroup(string name);
        Task<ICollection<IngredientDto>?> FindBySecondaryGroup(int id);
        Task<ICollection<IngredientDto>?> FindByTertiaryGroup(string name);
        Task<ICollection<IngredientDto>?> FindByTertiaryGroup(int id);

    }
}
