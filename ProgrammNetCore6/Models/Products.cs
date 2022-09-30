using ProgrammNetCore6.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammNetCore6.Models
{
    public class Products : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string? Img { get; set; }
        public string? Img1 { get; set; }
        public string? Img2 { get; set; }
        public string? Img3 { get; set; }
        public string? Img4 { get; set; }
        public bool IsActive { get; set; }
        public string? Articul { get; set; }
        public string? Character { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
