using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tasks.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "*")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name Minumum length 3")]
        public string Name { get; set; }

        [Range(18, 30, ErrorMessage = "Age Range Between 18 and 30")]
        public int Age { get; set; }

        [RegularExpression(@"[_A-Za-z0-9-.]+@[A-Za-z]+\.[A-Za-z]{2,3}", ErrorMessage = "Invalid Email")]
        //[Remote("CheckEmail", "Student", AdditionalFields = "Id", ErrorMessage = "Email in DB")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Your Password")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Password Must Be More Than 3 Digits")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Vaild To Confirm Pasword")]
        [DataType(DataType.Password)]
        [NotMapped]
        public string ConfirmPassword { get; set; }


        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public Department Department { get; set; }

        //public virtual Department? Department { get; set; }
    }
}
