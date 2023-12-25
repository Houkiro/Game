using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class User
    {
        [Column("UserId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is a required field")]
        [MaxLength(13, ErrorMessage = "Maximum length for the Name is 13 characters.")]
        public string? Name { get; set; }
    }
}
