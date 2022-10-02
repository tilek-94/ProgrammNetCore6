using Microsoft.AspNetCore.Mvc;
using ProgrammNetCore6.Data.AbstractService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammNetCore6.ViewComponents.Categoryes
{
    public class CategoryList : ViewComponent
    {
        private readonly ICategoryService _service;

        public CategoryList(ICategoryService service)
        {
            _service = service;
        }

        public IViewComponentResult Invoke()
        {
            var allCategory = _service.GetAll();
            return View(allCategory);
        }
    }
}
