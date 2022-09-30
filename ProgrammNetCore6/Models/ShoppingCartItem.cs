using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammNetCore6.Models
{

    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }
        public Products Products { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
