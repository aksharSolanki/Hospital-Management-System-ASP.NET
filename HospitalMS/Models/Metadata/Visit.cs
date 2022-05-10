using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalMS.Models
{
    [MetadataType(typeof(VisitAttributes))]
    public partial class Visit
    {
    }

    public partial class VisitAttributes
    {
        public int Id { get; set; }


        [Display(Name = "Date of Visit")]
        [Required(ErrorMessage = "Choose Date of Visit.")]
        public System.DateTime DateOfVisit { get; set; }


        public string Complaint { get; set; }


        [Display(Name = "Doctor")]
        public int DoctorId { get; set; }


        [Display(Name = "Patient")]
        public int PatientId { get; set; }


        [Display(Name = "Attending Doctor")]
        public virtual Doctor Doctor { get; set; }


        [Display(Name = "Patient")]
        public virtual Patient Patient { get; set; }
    }
}
