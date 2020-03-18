using OLX.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OLX.Domain;
using OLX.Options;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;

namespace OLX.Repo
{
    public class UserRepo : IUserRepo
    {
        private readonly DataContext _context;

        private readonly List<User> _users = new List<User> { };

        private readonly AppSettings _appSettings;

        public UserRepo(IOptions<AppSettings> appSettings, DataContext context)
        {
            _context = context;
            _appSettings = appSettings.Value;
        }
        public User Authenticate(string username, string password)
        {
            var user = _users.SingleOrDefault(x => x.Name == username && x.Password == password);

            if (user == null)
            { return null; }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {

                    new Claim(ClaimTypes.Name, user.Id.ToString())

                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)

            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);


            return user.WithoutPassword();
        }


        public IEnumerable<User> GetAll()
        {
            List<User> _users = _context.Users.ToList();
            return _users.WithoutPasswords();
        }

        public async Task<bool> AddUser(User user)
        {
            var sprawdzonko = await _context.Users.FirstOrDefaultAsync(x => user.Name == x.Name);
            if (sprawdzonko == null)
            {
                if (user == null || user.Password == null || user.Name == null)
                { return false; }

                else
                {
                    user.Id = Guid.NewGuid();
                    user.Messages = new List<Message> { };
                    user.Adverts = new List<Advert> { };
                    _context.Users.Add(user);
                    await _context.SaveChangesAsync();
                    return true;
                }
            }
            else return false;
        }



        public async Task<bool> DeleteUser(Guid Id)
        {
            var sprawdzonko = await _context.Users.FirstOrDefaultAsync(x => x.Id == Id);
            if(sprawdzonko==null)
            {
                return false;
            }
            else
            {

                _context.Users.Remove(sprawdzonko);
                await _context.SaveChangesAsync();
                return true;

            }
        }

    }
}