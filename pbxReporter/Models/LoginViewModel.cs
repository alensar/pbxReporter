using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pbxReporter.Models
{
    public class LoginViewModel
    {

        [Required]
        [Display(Name = "Korisničko ime:")]
        public string userName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Lozinka:")]
        public string Password { get; set; }

    }
    public class UserViewModel
    {
        public bool prosao { get; set; } = false;
        public string userName { get; set; }
        public string poruka { get; set; }
        public string extensionLow { get; set; }
        public string extensionHigh { get; set; }
        public string roles { get; set; }
        

    }
}
