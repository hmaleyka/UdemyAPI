using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyTask.Business.DTOs.CategoryDtos;
using UdemyTask.Business.Services.Interfaces;
using UdemyTask.Core.Entities;
using UdemyTask.DAL.Repositories.Interfaces;

namespace UdemyTask.Business.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repo;

        public CategoryService(ICategoryRepository repo)
        {
            _repo = repo;
        }
        public async  Task<Category> Create(CategoryCreateDto categorydto)
        {
            if (categorydto == null) throw new Exception("Category should noy be null");
            Category category = new Category()
            {
                Name = categorydto.Name,
                IsDeleted = false,
                CreatedAt = DateTime.Now,
            };
            await _repo.Create(category);
            await _repo.SaveChangesAsync();
            return category;
        }

        public async Task<ICollection<Category>> GetAllAsync()
        {
            var categories = await _repo.GetAllAsync();

            return await categories.ToListAsync();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            if (id <= 0) throw new Exception("Id can't be less than zero");
            var category = await _repo.GetByIdAsync(id);
            if (category == null) throw new Exception("category should not be null");
            return category;
        }

        public async Task<Category> Update(int id, CategoryUpdateDto categorydto)
        {
            if (categorydto.Id <= 0) throw new Exception("Id should not be less than zero");
            Category category = await _repo.GetByIdAsync(id);
            if (category == null) throw new Exception("Category should not be null");
            category.Name = categorydto.Name;
            category.IsDeleted = false;
            category.UpdatedAt = DateTime.Now;
            _repo.Update(category);
            await _repo.SaveChangesAsync();
            return category;
        }
        public async Task<Category> Delete(int id)
        {
            var category = await _repo.GetByIdAsync(id);
            if (category == null) throw new Exception("Category should not be null");
            _repo.Delete(id);
            category.IsDeleted= true;
            await _repo.SaveChangesAsync();
            return category;
        }
    }
}
