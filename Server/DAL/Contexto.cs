using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace _3Ecommerce.Server.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Product> Product { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
        
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "Dodge Charger SRT HellCat WideBody 2021",
                        Description = "V8 huge dodge car, Cesar´s fav",
                        ImageUrl = "https://ag-spots-2021.o.auroraobjects.eu/2021/07/04/dodge-charger-srt-hellcat-widebody-c883704072021053710_5.jpg?1625369847",
                        Price = 890000.99m

                    },

                    new Product
                    {
                        Id = 2,
                        Title = "Dodge Charger SRT HellCat WideBody 2021",
                        Description = "V10 Wide Agressive car, Like a Vin Diesel actor Fav car",
                        ImageUrl = "https://ag-spots-2021.o.auroraobjects.eu/2021/03/03/dodge-challenger-srt-hellcat-widebody-2019-c277503032021013737_3.jpg",
                        Price = 57000.99m,
                    },

                    new Product
                    {
                        Id = 3,
                        Title = "2022 Dodge RAM TRX",
                        Description = " T-Rex that eating RAPTORS becomes a truck, our Daddy´s Really like this",
                        ImageUrl = "https://lifestyleautogroup.ca/wp-content/uploads/2022/04/TRX-03-scaled.jpg",
                        Price = 120000.99m,
                    });
        }
    }
}
