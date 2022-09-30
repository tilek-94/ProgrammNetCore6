using ProgrammNetCore6.Data.AbstractService;
using ProgrammNetCore6.Data.Base;
using ProgrammNetCore6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammNetCore6.Data.Services
{
    public class CategoryService : EntityBaseRepository<Category>, ICategoryService
    {
        private readonly AppDbContext _context;
        public CategoryService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Categories.ToList();
        }
    }
}
