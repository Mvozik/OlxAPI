using OLX.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OLX.Domain;

namespace OLX.Repo
{
    public class SubcategoryRepo : ISubCategoryRepo
    {
        private readonly DataContext _context;
        public SubcategoryRepo(DataContext context)
        {
            _context = context;
        }
        public async Task<bool> AddSubCategory(Subcategory Subcategory)
        {
            if (Subcategory.Name == null)
            { return false; }
            else
            {
                Subcategory.Id = Guid.NewGuid();
                await _context.Subcategories.AddAsync(Subcategory);
                await _context.SaveChangesAsync();
                return true;
            }

        }

        public async Task<bool> DeleteSubCategory(Guid Id)
        {
            var Subcategory = await _context.Subcategories.FirstOrDefaultAsync(u => u.Id == Id);
            if (Subcategory == null)
            {
                return false;
            }
            else
            {
                _context.Subcategories.Remove(Subcategory);
                await _context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<List<Subcategory>> GetSubCategories()
        {
            var Subcategories = await _context.Subcategories.ToListAsync();
            if (Subcategories == null)
                return null;
            return Subcategories;
        }

        public async Task<Subcategory> GetSubCategory(Guid Id)
        {
            var Subcategory = await _context.Subcategories.FirstOrDefaultAsync(u => u.Id == Id);

            return Subcategory;
        }

        public async Task<bool> UpdateSubCategory(Subcategory Subcategory)
        {
            _context.Subcategories.Update(Subcategory);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }
    }
}
