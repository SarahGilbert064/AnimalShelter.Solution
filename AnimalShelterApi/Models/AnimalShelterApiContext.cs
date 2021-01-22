using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext>options)
      : base(options)
      {
      }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Cat>()
        .HasData(
          new Cat { CatId = 1, Name = "Charlie", Breed = "Russian Blue", Age = "2 years old"},
          new Cat { CatId = 2, Name = "Max", Breed = "Tabby", Age = "10 years old"},
          new Cat { CatId = 3, Name = "Barry", Breed = "Siamese", Age = "6 months old"}
        );

      builder.Entity<Dog>()
        .HasData(
          new Dog { DogId = 1, Name = "Kika", Breed = "German Shepard", Age = "12 years old"},
          new Dog { DogId = 2, Name = "Daisy", Breed = "Pitbull Mix", Age = "6 years old"},
          new Dog { DogId = 3, Name = "Maya", Breed = "Siberian Husky", Age = "3 months old"}
        );
    }
      public DbSet<Dog> Dogs { get; set; }
      public DbSet<Cat> Cats { get; set; }
  }
}