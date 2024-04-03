using cakesdri_api.Models;

namespace cakesdri_api.Interfaces
{
  public interface IRecipeRepository
  {
    void Insert(Recipe recipe);
    void Update(Recipe recipe);
    void Delete(int id);
    Task<Recipe> GetById(int id);
    Task<IEnumerable<Recipe>> GetAll();
  } 
}
