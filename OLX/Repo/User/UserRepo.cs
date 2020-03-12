using OLX.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLX.Repo
{
    public class UserRepo : IUserRepo
    {
        private readonly DataContext _context;
        public UserRepo(DataContext context)
        {
            _context = context;
        }
        public Task<bool> AddAUser(UserRepo user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUser(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<UserRepo> GetUser(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserRepo>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUser(UserRepo user)
        {
            throw new NotImplementedException();
        }
    }
}
