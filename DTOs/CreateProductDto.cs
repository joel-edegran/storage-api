using System.ComponentModel.DataAnnotations;

namespace StorageApi.DTOs;

public class CreateProductDto
{
    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [Range(0, 1000000)]
    public int Price { get; set; }

    [Required]
    [StringLength(50)]
    public string Category { get; set; } = string.Empty;

    [Required]
    [StringLength(10)]
    public string Shelf { get; set; } = string.Empty;

    [Range(0, 10000)]
    public int Count { get; set; }

    public string Description { get; set; } = string.Empty;
}
