using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalMS.Models
{
    [MetadataType(typeof(UserAttributes))]
    public partial class User
    {
    }

    public partial class UserAttributes
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

