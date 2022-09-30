using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammNetCore6.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        /*[ForeignKey(nameof(UserId))]*/
        /* public ApplicationUser User { get; set; }*/
        public string Addres { get; set; }
        public string Phone { get; set; }
        public DateTime Date { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
