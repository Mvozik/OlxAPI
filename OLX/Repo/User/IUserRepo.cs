using OLX.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLX.Repo
{
    interface IUserRepo
    {
        Task<List<UserRepo>> GetUsers();
        Task<UserRepo> GetUser(Guid Id);
        Task<bool> DeleteUser(Guid Id);
        Task<bool> UpdateUser(UserRepo user);
        Task<bool> AddAUser(UserRepo user);
    }
}
