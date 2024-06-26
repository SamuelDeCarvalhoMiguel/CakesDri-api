using cakesdri_api.Interfaces.Repository;
using cakesdri_api.Interfaces.Service;
using cakesdri_api.Models;
using cakesdri_api.Repositories;
using cakesdri_api.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

IConfigurationRoot Configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

#region Database
builder.Services.AddDbContext<CakesdriContext>(options =>
{
  options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
});
#endregion

#region Cors
builder.Services.AddCors();
#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Adicionando o escopo da interface
builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();
builder.Services.AddScoped<IRecipeService, RecipeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(cors =>
{
  cors.AllowAnyHeader();
  cors.AllowAnyMethod();
  cors.AllowAnyOrigin();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
