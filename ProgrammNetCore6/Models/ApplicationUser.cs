using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammNetCore6.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Display(Name ="Full Name")]
        public string? FullName { get; set; }
    }
}
