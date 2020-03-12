using OLX.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLX.Repo
{
    interface ISubCategoryRepo
    {
        Task<List<SubcategoryRepo>> GetSubcategories();
        Task<SubcategoryRepo> GetSubcategory(Guid Id);
        Task<bool> DeleteSubcategory(Guid Id);
        Task<bool> UpdateSubcategory(SubcategoryRepo subcategory);
        Task<bool> AddSubcategory(SubcategoryRepo subcategory);
    }
}
