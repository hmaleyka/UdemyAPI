using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyTask.Core.Entities;
using UdemyTask.DAL.Context;
using UdemyTask.DAL.Repositories.Interfaces;

namespace UdemyTask.DAL.Repositories.Implementations
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext dbcontext) : base(dbcontext)
        {
        }
    }
}
