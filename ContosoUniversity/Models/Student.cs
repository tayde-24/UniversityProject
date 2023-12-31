﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student : Person
    {
        /*public int ID { get; set; }
        [StringLength(50, MinimumLength =2), RegularExpression(@"^[A-Z]+[a-zA-Z]*$"), Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [StringLength(50), RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Column("FirstName"), Required]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }*/

        /*[Display(Name = "Full Name")]
        public string FullName {
            get {
                return LastName + ", " + FirstMidName;
            }
        }*/

        [DataType(DataType.Date)]
        [Display(Name = "Enrollment Date")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
