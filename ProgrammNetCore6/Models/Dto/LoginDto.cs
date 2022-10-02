using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProgrammNetCore6.Models.Dto
{
    public class LoginDto
    {
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Введите email адресс пожалуйста")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Введите пароль пожалуйста")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
