using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa() { 
                    Id = 1,
                    Name="bangalo",
                    Description="vaste",
                    Superficie= 15,
                    NbRoom=2,
                    ImageUrl= "https://cdn.pixabay.com/photo/2016/06/24/10/47/house-1477041_960_720.jpg",
                    Rate=1,
                    Created_date= DateTime.Now,
                
                },
                
            
                new Villa()
                {
                    Id = 2,
                    Name = "maison",
                    Description = "beau",
                    Superficie = 20,
                    NbRoom = 3,
                    ImageUrl = "https://pixabay.com/photos/lost-places-villa-ruins-abandoned-2759275/",
                    Rate=1,
                    Created_date= DateTime.Now,



                },

                
            
                new Villa()
                {
                    Id = 3,
                    Name = "s+3",
                    Description = "grand",
                    Superficie = 180,
                    NbRoom = 5,
                    ImageUrl = "https://pixabay.com/photos/lost-places-villa-ruins-abandoned-2759275/",
                    Rate = 1,
                    Created_date= DateTime.Now,

                }
                );



        }

    }
}
