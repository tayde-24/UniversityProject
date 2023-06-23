using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [StringLength(50, MinimumLength =2), RegularExpression(@"^[A-Z]+[a-zA-Z]*$"), Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [StringLength(50), RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Column("FirstName"), Required]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Enrollment Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName {
            get {
                return LastName + ", " + FirstMidName;
            }
        }

        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
