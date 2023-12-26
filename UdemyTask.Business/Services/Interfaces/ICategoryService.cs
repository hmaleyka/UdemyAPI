using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyTask.Business.DTOs.CategoryDtos;
using UdemyTask.Core.Entities;

namespace UdemyTask.Business.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<ICollection<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task<Category> Create(CategoryCreateDto categorydto);
        Task<Category> Update(int id, CategoryUpdateDto categorydto);

        Task <Category> Delete(int id);
    }
}
