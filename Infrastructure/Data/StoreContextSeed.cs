using System.Runtime.Serialization.Json;
using System.Text.Json;
using Core.Entities;
using Infrastructure.Controllers.Data;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context)
        {
            if (!context.ProductBrands.Any())
            {
                var brandsData = File.ReadAllText("../Infrastructure/Data/SeedData/brands.json");
                var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);
                context.ProductBrands.AddRange(brands);
            }

            if (!context.ProductTypes.Any())
            {
                var typesData = File.ReadAllText("../Infrastructure/Data/SeedData/types.json");
                var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);
                context.ProductTypes.AddRange(types);
            }

            if (!context.Products.Any())
            {
                var productsData = File.ReadAllText("../Infrastructure/Data/SeedData/products.json");
                var products = JsonSerializer.Deserialize<List<Product>>(productsData);
                context.Products.AddRange(products);
            }

            if (!context.RoleTypes.Any())
            {
                var rolesData = File.ReadAllText("../Infrastructure/Data/SeedData/roles.json");
                var roles = JsonSerializer.Deserialize<List<RoleType>>(rolesData);
                context.RoleTypes.AddRange(roles);
            }

            if (!context.Users.Any())
            {
                var usersData = File.ReadAllText("../Infrastructure/Data/SeedData/users.json");
                var users = JsonSerializer.Deserialize<List<User>>(usersData);
                context.Users.AddRange(users);
            }

            if (context.ChangeTracker.HasChanges()) await context.SaveChangesAsync();
        }
    }
}