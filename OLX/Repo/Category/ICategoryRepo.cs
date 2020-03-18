using OLX.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLX.Repo
{
    public interface ICategoryRepo
    {
        Task<List<Category>> GetCategories();
        Task<Category> GetCategory(Guid Id);
        Task<bool> DeleteCategory(Guid Id);
        Task<bool> UpdateCategory(Category category);
        Task<bool> AddCategory(Category category);
    }
}
