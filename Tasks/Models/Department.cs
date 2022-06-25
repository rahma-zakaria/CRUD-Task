using System.ComponentModel.DataAnnotations;

namespace Tasks.Models
{
    public class Department : BaseEntity
    {
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Name Minumum length 4")]
        public string Location { get; set; }

    }
}
