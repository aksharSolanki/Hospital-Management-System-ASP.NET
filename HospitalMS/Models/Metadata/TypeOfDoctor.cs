using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalMS.Models
{
    [MetadataType(typeof(TypeOfDoctorAttributes))]
    public partial class TypeOfDoctor
    {
    }

    public partial class TypeOfDoctorAttributes
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}