using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class Employee
    {


        //name
        [Required(ErrorMessage = "Enter Nmae")]
        [StringLength(20, MinimumLength = 3)]
        public string? EmployeeName { get; set; }


        //Department
        [Required(ErrorMessage = "Select Department")]
        public string? Department { get; set; }

        //is active
        public bool isActive { get; set; }

        //job Title
        [Required(ErrorMessage = "job Title is Missing")]
        [DataType(DataType.Text)]
        public string? JobTitle { get; set; }

        //Date of Birth 
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        //EmailAddress
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? EmailAddress { get; set; }
    }
}
