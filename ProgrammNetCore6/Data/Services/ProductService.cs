using Microsoft.EntityFrameworkCore;
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
    public class ProductService : EntityBaseRepository<Products>, IProductService
    {
        private readonly AppDbContext _context;
        public ProductService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Products>> GetListProductByCategoryId(int id)
        {
            return await _context.Products.Where(x => x.CategoryId == id).ToListAsync();
        }

        public async Task<IEnumerable<Products>> GetListProductBySerarch(string name)
        {
            return await _context.Products.Where(x => x.Name.Contains(name) 
            || x.Character.Contains(name) 
            || x.Articul.Contains(name) 
            || x.Price.ToString().Contains(name))
                .ToArrayAsync();
        }
    }
}
