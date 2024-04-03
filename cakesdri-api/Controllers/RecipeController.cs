﻿using cakesdri_api.Interfaces.Service;
using cakesdri_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace cakesdri_api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class RecipeController : Controller
  {

    private readonly IRecipeService _recipeService;

    public RecipeController(IRecipeService recipeService)
    {
      _recipeService = recipeService;
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<IEnumerable<Recipe>>> GetAllRecipes()
    {
      return Ok(await _recipeService.GetAll());
    }

    [HttpPost("Insert")]
    public async Task<ActionResult> InsertRecipe(Recipe recipe)
    {
      _recipeService.Insert(recipe);
      if (await _recipeService.SaveAllAsync())
         return Ok(recipe);
      return BadRequest("Ocorreu um erro ao salvar a receita.");
    }
  }
}
