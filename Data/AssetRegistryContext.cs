using Microsoft.EntityFrameworkCore;

public class AssetRegistryContext(DbContextOptions<AssetRegistryContext> options) : DbContext(options)
{
    public DbSet<AssetRegistry.Models.User> User { get; set; } = default!;
}
