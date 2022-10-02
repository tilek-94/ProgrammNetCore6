using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammNetCore6.Models.Dto
{
    public class ClientDto
    {
        [Required(ErrorMessage = "Введите пожалуйста свой имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Введите пожалуйста свой адресс")]
        public string Addres { get; set; }
        [Required(ErrorMessage = "Введите пожалуйста свой телефон номер")]
        public string Phone { get; set; }

    }
}
