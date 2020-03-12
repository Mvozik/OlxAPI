using OLX.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLX.Repo
{
    public class SubcategoryRepo : ISubCategoryRepo
    {
        private readonly DataContext _context;
        public SubcategoryRepo(DataContext context)
        {
            _context = context;
        }
        public Task<bool> AddSubcategory(SubcategoryRepo subcategory)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSubcategory(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SubcategoryRepo>> GetSubcategories()
        {
            throw new NotImplementedException();
        }

        public Task<SubcategoryRepo> GetSubcategory(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateSubcategory(SubcategoryRepo subcategory)
        {
            throw new NotImplementedException();
        }
    }
}
