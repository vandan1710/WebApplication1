using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new WebApplication1Context(
            serviceProvider.GetRequiredService<
                DbContextOptions<WebApplication1Context>>()))
        {
            // Look for any movies.
            if (context.Project.Any())
            {
                return;   // DB has been seeded
            }
            context.Product.AddRange(
                new Product
                {
                    Title = "",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "SciFi",
                    Rating = "R",
                    Price = 7.99M
                },
                new Product
                {
                    Title = "",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "SciFi",
                    Rating = "R",
                    Price = 8.99M
                },
                new Product
                {
                    Title = "",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "SciFi",
                    Rating = "R",
                    Price = 9.99M
                },
                new Product
                {
                    Title = "",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "SciFi",
                    Rating = "R",
                    Price = 3.99M
                },
                new Product
                {
                    Title = "",
                    ReleaseDate = DateTime.Parse("2024-1-2"),
                    Genre = "Adventure",
                    Rating = "R",
                    Price = 5.70M
                }
            );
            context.SaveChanges();
        }
    }
}