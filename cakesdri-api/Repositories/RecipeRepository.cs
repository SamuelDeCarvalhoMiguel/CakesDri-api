using cakesdri_api.Interfaces.Repository;
using cakesdri_api.Models;
using Microsoft.EntityFrameworkCore;

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
      _context.Recipe.Add(recipe);
    }
    public void Update(Recipe recipe)
    {
      _context.Entry(recipe).State = EntityState.Modified;
    }

    public void Delete(Recipe recipe)
    {
      _context.Recipe.Remove(recipe);
    }

    public async Task<Recipe?> GetById(int id)
    {
      return await _context.Recipe.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<IEnumerable<Recipe?>> GetAll()
    {
      return await _context.Recipe.ToListAsync();
    }

    public async Task<bool> SaveAllAsync()
    {
      return await _context.SaveChangesAsync() > 0;
    }
  }
}
