using OLX.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLX.Repo
{
    public interface IUserRepo
    {
        User Authenticate(string username, string password);
        Task<bool> AddUser(User user);
        IEnumerable<User> GetAll();
        Task<bool> DeleteUser(Guid Id);


    }
}
