using EcommerceApi.Models;

namespace EcommerceApi.Data
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Products.Any())
            {
                var products = new List<Product>
                {
                    new Product { Name = "iPhone 15 Pro", Description = "Apple A17 Pro işlemci, 6.1 inç ekran, 256GB depolama", Price = 65000, Image = "https://via.placeholder.com/200" },
                    new Product { Name = "Samsung Galaxy S24", Description = "Snapdragon 8 Gen 3 işlemci, 6.8 inç AMOLED ekran", Price = 55000, Image = "https://via.placeholder.com/200" },
                    new Product { Name = "MacBook Air M2", Description = "Apple M2 çip, 8GB RAM, 256GB SSD, 13.6 inç ekran", Price = 42000, Image = "https://via.placeholder.com/200" },
                    new Product { Name = "Dell XPS 13", Description = "Intel i7 12. Nesil, 16GB RAM, 512GB SSD", Price = 38000, Image = "https://via.placeholder.com/200" },
                    new Product { Name = "Sony WH-1000XM5", Description = "Gürültü engelleme, 30 saat pil ömrü", Price = 12500, Image = "https://via.placeholder.com/200" },
                    new Product { Name = "Apple Watch Series 9", Description = "Always-on Retina ekran, sağlık takibi", Price = 18000, Image = "https://via.placeholder.com/200" },
                    new Product { Name = "Logitech MX Master 3S", Description = "Sessiz tıklama, uzun pil ömrü, ergonomik tasarım", Price = 3500, Image = "https://via.placeholder.com/200" },
                    new Product { Name = "Sony PlayStation 5", Description = "Ultra HD oyun deneyimi, DualSense kontrolcü", Price = 23000, Image = "https://via.placeholder.com/200" },
                    new Product { Name = "Xbox Series X", Description = "4K oyun desteği, hızlı yükleme", Price = 21000, Image= "https://via.placeholder.com/200" },
                    new Product { Name = "GoPro HERO11", Description = "5.3K video kaydı, su geçirmez tasarım", Price = 15000, Image = "https://via.placeholder.com/200" }
                };

                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }
    }
}
