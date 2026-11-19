using Microsoft.EntityFrameworkCore;

public class StorageApiContext(DbContextOptions<StorageApiContext> options) : DbContext(options)
{
    public DbSet<StorageApi.DTOs.ProductDto> Products { get; set; } = default!;
}
