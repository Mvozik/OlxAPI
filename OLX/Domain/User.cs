using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLX.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string Phonenumber { get; set; }
        public byte[] Passwordhash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Advert> Adverts { get; set; }
        public List<Message> Messages{ get; set; }
        public bool Isadmin { get; set; }
    }
}
