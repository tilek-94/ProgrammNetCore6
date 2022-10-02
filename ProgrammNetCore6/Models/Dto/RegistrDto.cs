using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProgrammNetCore6.Models.Dto
{
    public class RegistrDto
    {
        [Display(Name = "Ф.И.О")]
        [Required(ErrorMessage = "Заполните полное имя.")]
        public string FullName { get; set; }

        [Display(Name = "Дата рождения")]
        [Required(ErrorMessage = "Заполните полное дата рождения.")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Номер телефона")]
        [Required(ErrorMessage = "Заполните полное номер телефона")]
        public string? PhoneNumber { get; set; }

        [Display(Name = "Адресс")]
        [Required(ErrorMessage = "Заполните полное адресса")]
        public string? Address { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Заполните полное Email")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Подтвердить пароль")]
        [Required(ErrorMessage = "Требуется подтверждение пароля")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }

    }
}
