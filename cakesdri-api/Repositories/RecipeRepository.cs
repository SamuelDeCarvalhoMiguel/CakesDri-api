using cakesdri_api.Interfaces;
using cakesdri_api.Models;

namespace cakesdri_api.Repositories
{
  public class RecipeRepository : IRecipeRepository
  {
    private readonly CakesdriContext _context;

    public RecipeRepository(CakesdriContext context)
    {
      _context = context;
    }

    public void Insert(Recipe recipe)
    {
      throw new NotImplementedException();
    }
    public void Update(Recipe recipe)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public Task<Recipe> GetById(int id)
    {
      throw new NotImplementedException();
    }

    public Task<IEnumerable<Recipe>> GetAll()
    {
      throw new NotImplementedException();
    }
  }
}
