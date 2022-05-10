using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalMS.Models
{
    [MetadataType(typeof(PatientAttributes))]
    public partial class Patient
    {
    }

    public partial class PatientAttributes
    {
        public int Id { get; set; }


        [Required(ErrorMessage ="Enter patient's Name.")] 
        public string Name { get; set; }


        [EmailAddress(ErrorMessage ="Enter a valid Email address.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Enter patient's Address.")]
        public string Address { get; set; }


        [Required(ErrorMessage = "Enter patient's Telephone.")]
        [RegularExpression("[0-9]{3}-[0-9]{3}-[0-9]{4}")]
        public string Telephone { get; set; }


        [Required(ErrorMessage = "Enter patient's Date of Birth.")]
        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public System.DateTime DateOfBirth { get; set; }

        public int DoctorId { get; set; }

        public virtual ICollection<Admission> Admissions { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}