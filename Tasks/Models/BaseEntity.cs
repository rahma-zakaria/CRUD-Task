using System.ComponentModel.DataAnnotations;

namespace Tasks.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name Minumum length 2")]
        public string Name { get; set; }
    }
}
