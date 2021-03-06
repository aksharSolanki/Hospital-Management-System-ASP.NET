//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient
    {
        public Patient()
        {
            this.Admissions = new HashSet<Admission>();
            this.Visits = new HashSet<Visit>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public int DoctorId { get; set; }
    
        public virtual ICollection<Admission> Admissions { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
