﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace E_CommerceWebsiteUsingNetCoreMVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Clothes", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Grocery", DisplayOrder = 3 }
                );
        }

    }
}
