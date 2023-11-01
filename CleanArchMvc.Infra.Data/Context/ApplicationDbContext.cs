﻿using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Infra.Data.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;

namespace CleanArchMvc.Infra.Data.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
    {
        
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        //verifica e aplica as configurações das classes EntitiesConfiguration
        builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        
        //É possível fazer individualmente para cada classe EntitiesConfiguration
        //builder.ApplyConfiguration(new CategoryConfiguration());

    }
}
