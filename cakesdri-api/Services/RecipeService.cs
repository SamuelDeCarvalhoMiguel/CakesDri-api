using cakesdri_api.Interfaces.Repository;
using cakesdri_api.Interfaces.Service;
using cakesdri_api.Models;
using cakesdri_api.Repositories;
using Microsoft.AspNetCore.Mvc;

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

    public async Task<string> UploadImage(IFormFile? file)
    {
      if (file == null)
        return "No file uploaded";

      //Generate a unique filename or use the original filename
      var fileName = file.FileName;

      //Define the path to save the image
      var filePath = Path.Combine("C:\\Users\\Sam\\source\\repos\\Meus projetos\\cakesdri-api\\Images", fileName);

      //Save the image to the path
      using (var stream = new FileStream(filePath, FileMode.Create))
      {
        await file.CopyToAsync(stream);
      }

      return filePath;
    }
  }
}
