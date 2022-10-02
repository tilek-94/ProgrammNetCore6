using Microsoft.AspNetCore.Mvc;
using ProgrammNetCore6.Data.AbstractService;
using ProgrammNetCore6.Data.Cart;
using ProgrammNetCore6.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Program1.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IProductService _productService;
        private readonly ShoppingCart _shoppingCart;
        private readonly IOrdersService _ordersService;

        public OrdersController(IProductService productService, ShoppingCart shoppingCart, IOrdersService ordersService)
        {
            _productService = productService;
            _shoppingCart = shoppingCart;
            _ordersService = ordersService;
        }
        public IActionResult ShoppingCart()
        {
            var item = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = item;
            var response = new ShopingCartDto
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(response);
        }
        public PartialViewResult RegisterClient()
        {
            return PartialView(new ClientDto());
        }

        public async Task<IActionResult> AddItemToShoppingCart(int id)
        {
            var item = await _productService.GetByIdAsync(id);

            if (item != null)
            {
                _shoppingCart.AddItemToCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<IActionResult> AddItemToShoppingCartWithAjax(int id)
        {
            var item = await _productService.GetByIdAsync(id);

            if (item != null)
            {
                _shoppingCart.AddItemToCart(item);
            }
            var CountItems = await _shoppingCart.GetShoppingCartCountAsync();
            return Json(CountItems);
        }

        public async Task<IActionResult> RemoveItemFromShoppingCart(int id)
        {
            var item = await _productService.GetByIdAsync(id);

            if (item != null)
            {
                _shoppingCart.RemoveItemFromCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }
        public async Task<IActionResult> CompleteOrder(ClientDto client)
        {
            
            var items = _shoppingCart.GetShoppingCartItems();
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier); 
            if (userId != null)
            {
                await _ordersService.StoreOrderAsync(items, userId);
            }
            else
            {
                await _ordersService.StoreOrderWithoutUserAsync(items, client.Name, client.Addres, client.Phone);
            }
            await _shoppingCart.ClearShoppingCartAsync();

            return RedirectToAction(nameof(ShoppingCart));
        }
    }
}
