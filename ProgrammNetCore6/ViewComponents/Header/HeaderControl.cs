using Microsoft.AspNetCore.Mvc;
using ProgrammNetCore6.Data.AbstractService;
using ProgrammNetCore6.Data.Cart;

namespace ProgrammNetCore6.ViewComponents.Header
{
    public class HeaderControl : ViewComponent
    {
        private readonly IProductService _productService;
        private readonly ShoppingCart _shoppingCart;

        public HeaderControl(IProductService productService, ShoppingCart shoppingCart)
        {
            _productService = productService;
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var countProduct=  _shoppingCart.GetShoppingCartCount();
            ViewBag.CountProduct = countProduct;
           return View();
        }
    }
}
