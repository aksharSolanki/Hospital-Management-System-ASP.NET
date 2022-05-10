using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalMS.Models
{
    [MetadataType(typeof(AdmissionAttributes))]
    public partial class Admission
    {
    }

    public partial class AdmissionAttributes
    {
        public int Id { get; set; }


        [Display(Name = "Patient")]
        public int PatientId { get; set; }


        [Required(ErrorMessage = "Choose Date of Admission.")]
        [Display(Name = "Date of Admission")]
        public System.DateTime AdmissionDate { get; set; }


        [Display(Name = "Date of Discharge")]
        public Nullable<System.DateTime> DischargeDate { get; set; }


        public virtual Patient Patient { get; set; }
    }
}