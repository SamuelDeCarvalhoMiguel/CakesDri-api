using cakesdri_api.Interfaces.Repository;
using cakesdri_api.Interfaces.Service;
using cakesdri_api.Models;
using cakesdri_api.Repositories;

namespace cakesdri_api.Services
{
  public class RecipeService : IRecipeService
  {
    private readonly IRecipeRepository _recipeRepository;
    public RecipeService(IRecipeRepository recipeRepository)
    {
      _recipeRepository = recipeRepository;
    }

    public void Insert(Recipe recipe)
    {
      _recipeRepository.Insert(recipe);
    }

    public void Update(Recipe recipe)
    {
      throw new NotImplementedException();
    }

    public void Delete(Recipe recipe)
    {
      throw new NotImplementedException();

    }

    public Task<Recipe?> GetById(int id)
    {
      throw new NotImplementedException();
    }

    public async Task<IEnumerable<Recipe?>> GetAll()
    {
      return await _recipeRepository.GetAll();
    }

    public async Task<bool> SaveAllAsync()
    {
      return await _recipeRepository.SaveAllAsync();
    }

   
  }
}
