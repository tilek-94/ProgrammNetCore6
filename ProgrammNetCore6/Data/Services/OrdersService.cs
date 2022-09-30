using Microsoft.EntityFrameworkCore;
using ProgrammNetCore6.Data.AbstractService;
using ProgrammNetCore6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammNetCore6.Data.Services
{
    public class OrdersService:IOrdersService
    {
        private readonly AppDbContext _context;
        public OrdersService(AppDbContext context)
        {
            _context = context;
        }
        /*public async Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole)
        {
            var orders = await _context.Orders.Include(n => n.OrderItems).ThenInclude(n => n.Movie)
             .Include(n => n.User).ToListAsync();
            if (userRole != "Admin")
            {
                orders = orders.Where(n => n.UserId == userId).ToList();
            }
            return orders;
        }*/

        public async Task StoreOrderAsync(List<ShoppingCartItem> items, string userId)
        {
            
                var order = new Order()
                {
                    UserId = userId,
                    Date = DateTime.Now
                };
                await _context.Orders.AddAsync(order);

            
            await _context.SaveChangesAsync();

            foreach (var item in items)
            {
                var orderItem = new OrderItem()
                {
                    Amount = item.Amount,
                    ProductsId = item.Products.Id,
                    OrderId = order.Id,
                    Price = item.Products.Price
                };
                await _context.OrderItems.AddAsync(orderItem);
            }
            await _context.SaveChangesAsync();
        }
        public async Task StoreOrderWithoutUserAsync(List<ShoppingCartItem> items, string name, string address,string phone)
        {

            var order = new Order()
            {
                Name = name,
                Addres=address,
                Phone=phone,
                Date = DateTime.Now
            };
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            foreach (var item in items)
            {
                var orderItem = new OrderItem()
                {
                    Amount = item.Amount,
                    ProductsId = item.Products.Id,
                    OrderId = order.Id,
                    Price = item.Products.Price
                };
                await _context.OrderItems.AddAsync(orderItem);
            }
            await _context.SaveChangesAsync();
        }


    }
}
