using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OLX.Data;
using OLX.Domain;

namespace OLX.Repo
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly DataContext _context;
        public CategoryRepo(DataContext context)
        {
            _context = context;
        }
        public async Task<bool> AddCategory(Category category)
        {
             if (category.Name == null)
            { return false; }
            else
            {
                category.Id = Guid.NewGuid();
               await _context.Categories.AddAsync(category);
               await _context.SaveChangesAsync();
               return true;
            }

        }

        public async Task<bool> DeleteCategory(Guid Id)
        {
            var Category = await _context.Categories.FirstOrDefaultAsync(u => u.Id == Id);
            if (Category == null)
            { 
            return false;
            }
            else 
            { 
            _context.Categories.Remove(Category);
            await _context.SaveChangesAsync();
            return true;
            }
        }

        public async Task<List<Category>> GetCategories()
        {
            var categories = await _context.Categories.ToListAsync();
            if (categories == null)
                return null;
            return categories;
        }

        public async Task<Category> GetCategory(Guid Id)
        {
            var Category = await _context.Categories.FirstOrDefaultAsync(u => u.Id == Id);

            return Category;
        }

        public async Task<bool> UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }
    }
}
