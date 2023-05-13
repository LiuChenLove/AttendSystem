using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AttendSystem.Models
{
    public class UserLoginModel
    {
        public int id { get; set; }

    }
    public class UserLoginRequest
    {
        [Required]
        [Display(Name ="帳號")]
        public string account { get; set; }

        [Required]
        [Display(Name = "密碼")]
        public string password { get; set; }

    }
}