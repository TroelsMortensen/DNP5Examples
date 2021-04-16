using System.Collections.Generic;
using IncludeExample.Models;
using Microsoft.EntityFrameworkCore;

namespace IncludeExample.DataAccess
{
    public class AuthorContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                @"Data Source = C:\TRMO\.NET projects\DNP-5.0-Examples\EFC\IncludeExample\Authors.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Address>().HasKey(address => new
            {
                address.HouseNumber, 
                street = address.Street,
                address.PostCode
            });
        }
    }
}