using Microsoft.OpenApi.MicrosoftExtensions;
using System.ComponentModel.DataAnnotations;

namespace StorageApi.DTOs
{
    public class ProductDto
    {
        public ProductDto(int id, string name, int price, string category, string shelf, int count, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
            Shelf = shelf;
            Count = count;
            Description = description;
        }


        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Range(10, 100000, ErrorMessage = "Price must be between 10 - 100000")]
        public int Price { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "String length of Categor must be 3 -20")]
        public string Category { get; set; }
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }

        public int InventoryValue => Price * Count;

    }
}
