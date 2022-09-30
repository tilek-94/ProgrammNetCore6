using ProgrammNetCore6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammNetCore6.Data.AbstractService
{
    public interface IOrdersService 
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId);
        Task StoreOrderWithoutUserAsync(List<ShoppingCartItem> items, string name, string address, string phone);
       // Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);
    }
}
