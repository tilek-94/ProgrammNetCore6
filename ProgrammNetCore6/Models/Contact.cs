using ProgrammNetCore6.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammNetCore6.Models
{
    public class Contact : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Addres { get; set; }
        public string? Phone { get; set; }
        public string? CallPhone { get; set; }
        public string? Email { get; set; }
        public string? Map { get; set; }
    }
}
