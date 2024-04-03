using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace cakesdri_api.Models;

public partial class CakesdriContext : DbContext
{
    public CakesdriContext(DbContextOptions<CakesdriContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Recipe> Recipes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Recipes__3213E83FA35F31CA");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}