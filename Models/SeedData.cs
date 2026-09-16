using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(MvcMovieContext context)
    {
        context.Database.EnsureCreated();

        if (context.Movies.Any())
        {
            return;
        }

        context.Movies.AddRange(
            new Movie
            {
                Title = "The Matrix",
                ReleaseDate = new DateTime(1999, 3, 31),
                Genre = "Sci-Fi",
                Price = 14.99m,
                Rating = 5
            },
            new Movie
            {
                Title = "Spirited Away",
                ReleaseDate = new DateTime(2001, 7, 20),
                Genre = "Animation",
                Price = 12.99m,
                Rating = 5
            },
            new Movie
            {
                Title = "The Dark Knight",
                ReleaseDate = new DateTime(2008, 7, 18),
                Genre = "Action",
                Price = 16.99m,
                Rating = 5
            },
            new Movie
            {
                Title = "Inception",
                ReleaseDate = new DateTime(2010, 7, 16),
                Genre = "Thriller",
                Price = 15.49m,
                Rating = 4
            },
            new Movie
            {
                Title = "The Princess Bride",
                ReleaseDate = new DateTime(1987, 9, 25),
                Genre = "Adventure",
                Price = 11.99m,
                Rating = 5
            }
        );

        context.SaveChanges();
    }
}
