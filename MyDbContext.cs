
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EntityAssetTracking3
{
    internal class MyDbContext : DbContext
{
    string connectionString = "Server=(localdb)\\mssqllocaldb;Database=EntityAssetT3Db;Trusted_Connection=True;MultipleActiveResultSets=true";
        public DbSet<Asset> Assets { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // We tell the app to use the connectionstring.
        optionsBuilder.UseSqlServer(connectionString);
    }
    protected override void OnModelCreating(ModelBuilder ModelBuilder)
    {
            ModelBuilder.Entity<Asset>().HasData(new Asset { Id = 1, Type = "Laptop", Brand = "MacBook", Model = "Air", PurchaseDate = Convert.ToDateTime("2020-11-03"), Office = "England", Price = 1800, Currency = "GBP", ExchangeRate = 1.15 });
            ModelBuilder.Entity<Asset>().HasData(new Asset { Id = 2, Type = "Laptop", Brand = "Asus", Model = "B42", PurchaseDate = Convert.ToDateTime("2018-12-14"), Office = "Spain", Price = 500, Currency = "EUR", ExchangeRate = 1.00 });
            ModelBuilder.Entity<Asset>().HasData(new Asset { Id = 3, Type = "Laptop", Brand = "Lenovo", Model = "Yoga 9", PurchaseDate = Convert.ToDateTime("2019-07-14"), Office = "Sweden", Price = 610, Currency = "SEK", ExchangeRate = 0.09 });
            ModelBuilder.Entity<Asset>().HasData(new Asset { Id = 4, Type = "Laptop", Brand = "HP", Model = "EliteBook", PurchaseDate = Convert.ToDateTime("2021-03-07"), Office = "Sweden", Price = 1760, Currency = "SEK", ExchangeRate = 0.09 });
            ModelBuilder.Entity<Asset>().HasData(new Asset { Id = 5, Type = "Phone", Brand = "Iphone", Model = "13 Pro", PurchaseDate = Convert.ToDateTime("2021-08-23"), Office = "Sweden", Price = 1360, Currency = "SEK", ExchangeRate = 0.09 });
            ModelBuilder.Entity<Asset>().HasData(new Asset { Id = 6, Type = "Phone", Brand = "Samsung", Model = "Galaxy", PurchaseDate = Convert.ToDateTime("2019-11-30"), Office = "Spain", Price = 800, Currency = "EUR", ExchangeRate = 1.00 });
            ModelBuilder.Entity<Asset>().HasData(new Asset { Id = 7, Type = "Phone", Brand = "Nokia", Model = "V Flip", PurchaseDate = Convert.ToDateTime("2022-02-01"), Office = "Sweden", Price = 1030, Currency = "SEK", ExchangeRate = 0.09 });
            ModelBuilder.Entity<Asset>().HasData(new Asset { Id = 8, Type = "Phone", Brand = "Iphone", Model = "12 Mini", PurchaseDate = Convert.ToDateTime("2020-01-03"), Office = "Spain", Price = 980, Currency = "EUR", ExchangeRate = 1.00 });
            ModelBuilder.Entity<Asset>().HasData(new Asset { Id = 9, Type = "Laptop", Brand = "Asus", Model = "X515", PurchaseDate = Convert.ToDateTime("2018-11-29"), Office = "England", Price = 700, Currency = "GBP", ExchangeRate = 1.15 });
            ModelBuilder.Entity<Asset>().HasData(new Asset { Id = 10, Type = "Phone", Brand = "Samsung", Model = "Flip2", PurchaseDate = Convert.ToDateTime("2019-01-03"), Office = "Sweden", Price = 980, Currency = "SEK", ExchangeRate = 0.09 });

        }
    }
}
