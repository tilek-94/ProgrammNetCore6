using ProgrammNetCore6.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammNetCore6.Models
{    public class Category : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category? ParentCategory{ get; set; }
        public int TypeCategory { get; set; }
        public string? Img { get; set; }
        public string? Icon { get; set; }
        public bool CategoryStatus { get; set; }

    }
}
