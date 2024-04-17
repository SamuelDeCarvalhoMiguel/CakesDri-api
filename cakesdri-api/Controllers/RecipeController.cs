using cakesdri_api.Interfaces.Service;
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

    [HttpGet("GetById/{id}")]
    public async Task<ActionResult<IEnumerable<Recipe>>> GetById(int id)
    {
      return Ok(await _recipeService.GetById(id));
    }

    [HttpPost("Insert")]
    public async Task<ActionResult> InsertRecipe(Recipe recipe)
    {
      _recipeService.Insert(recipe);
      if (await _recipeService.SaveAllAsync())
         return Ok(recipe);
      return BadRequest("Ocorreu um erro ao salvar a receita.");
    }

    [HttpPost("UploadImage")]
    public async Task<IActionResult> UploadImage(IFormFile file)
    { 
      return Ok(await _recipeService.UploadImage(file));
    }

  }
}
