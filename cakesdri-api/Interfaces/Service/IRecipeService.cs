﻿using cakesdri_api.Models;

namespace cakesdri_api.Interfaces.Service
{
  public interface IRecipeService
  {
    void Insert(Recipe recipe);
    void Update(Recipe recipe);
    void Delete(Recipe recipe);
    Task<Recipe?> GetById(int id);
    Task<IEnumerable<Recipe?>> GetAll();
    Task<bool> SaveAllAsync();
  }
}
