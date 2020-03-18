using OLX.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLX.Repo
{
    public interface ISubCategoryRepo
    {
        Task<List<Subcategory>> GetSubCategories();
        Task<Subcategory> GetSubCategory(Guid Id);
        Task<bool> DeleteSubCategory(Guid Id);
        Task<bool> UpdateSubCategory(Subcategory subcategory);
        Task<bool> AddSubCategory(Subcategory subcategory);
    }
}
