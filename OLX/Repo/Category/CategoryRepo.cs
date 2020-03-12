using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public Task<bool> AddCategor(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCategory(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategory(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
