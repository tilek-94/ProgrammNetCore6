using ProgrammNetCore6.Data.Base;
using ProgrammNetCore6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammNetCore6.Data.AbstractService
{
    public interface ICategoryService : IEntityBaseRepository<Category>
    {
        IEnumerable<Category> GetAll();
    }
}
