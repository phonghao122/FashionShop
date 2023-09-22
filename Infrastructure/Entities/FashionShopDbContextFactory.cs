using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Entities
{
	//TNT91
	public class FashionShopDbContextFactory : IDesignTimeDbContextFactory<FashionShopDbContext>
    {
        public FashionShopDbContext CreateDbContext(string[] args)
        {
            // chỉ ra sẽ đọc dữ liệu ở trong file appsettings.json của Infrastructure
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<FashionShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new FashionShopDbContext(optionsBuilder.Options);
        }
    }
}
