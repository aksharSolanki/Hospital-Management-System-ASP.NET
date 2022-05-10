using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalMS.Models
{
    [MetadataType(typeof(DoctorAttributes))]
    public partial class Doctor
    {
    }

    public partial class DoctorAttributes
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Enter doctor's Name.")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Enter doctor's Office.")]
        public string Office { get; set; }


        [Required(ErrorMessage = "Enter doctor's Email.")]
        [EmailAddress(ErrorMessage = "Enter a valid Email address.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Enter doctor's Telephone.")]
        [RegularExpression("[0-9]{3}-[0-9]{3}-[0-9]{4}")]
        public string Telephone { get; set; }


        [Required(ErrorMessage = "Enter doctor's Address.")]
        public string Address { get; set; }


        [Display(Name = "Type of Doctor")]
        public int TypeOfDoctorId { get; set; }


        [Display(Name = "Type of Doctor")]
        public virtual TypeOfDoctor TypeOfDoctor { get; set; }


        public virtual ICollection<Visit> Visits { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }

    }
}