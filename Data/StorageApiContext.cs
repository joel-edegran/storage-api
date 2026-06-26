using Microsoft.EntityFrameworkCore;

public class StorageApiContext(DbContextOptions<StorageApiContext> options) : DbContext(options)
{
    public DbSet<StorageApi.Models.Product> Product { get; set; } = default!;
}
