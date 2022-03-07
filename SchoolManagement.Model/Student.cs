using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.DataType(DataType.PhoneNumber)]
        [Display(Name = "Contact Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",ErrorMessage = "Entered phone format is not valid.")]
        public string ContactNumber { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Batch { get; set; }


        [Display(Name = "Addmission Date")]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName="Date")]
        public DateTime AddmissionDate { get; set; }
        public int RollNo { get; set; }


    }
}
