using System.ComponentModel.DataAnnotations;

namespace vidly1.Models
{
    public class GenreType
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
