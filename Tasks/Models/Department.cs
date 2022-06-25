using System.ComponentModel.DataAnnotations;

namespace Tasks.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name Minumum length 2")]
        public string Name { get; set; }

        [StringLength(50, MinimumLength = 4, ErrorMessage = "Name Minumum length 4")]
        public string Location { get; set; }

    }
}
