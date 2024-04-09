using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace cakesdri_api.Models;

public partial class Recipe
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }

    [Required]
    [Column("Title")]
    [StringLength(255)]
    public string? Title { get; set; }

    [Column("Description")]
    public string? Description { get; set; }

    [Column("ImageAdress")]
    public string? ImageAdress { get; set; }
}