using Microsoft.AspNetCore.Mvc;
using ProgrammNetCore6.Data.AbstractService;
using ProgrammNetCore6.Models;

namespace ProgrammNetCore6.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index(int id)
        {
            var allProduct = await _service.GetListProductByCategoryId(id);
            return View(allProduct);
        }
        public async Task<IActionResult> ContentProduct(int id)
        {
            Products values = await _service.GetByIdAsync(id);
            return View(values);
        } 
        public async Task<IActionResult> ProductSearch(string name)
        {
            var ProductBySearch = await _service.GetListProductBySerarch(name);
           return View(ProductBySearch);
        }
    }
}
