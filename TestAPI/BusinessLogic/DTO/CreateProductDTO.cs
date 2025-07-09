using System.ComponentModel.DataAnnotations;

namespace TestAPI.BusinessLogic.DTO
{
    public class CreateProductDTO
    {
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
        public string? Author { get; set; }
        [Required]
        public string? Category { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
