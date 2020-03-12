using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OLX.Data;
using OLX.Domain;

namespace OLX.Repo
{
    public class MessageRepo : IMessageRepo
    {
        private readonly DataContext _context;
        public MessageRepo(DataContext context)
        {
            _context = context;
        }
        public Task<bool> AddMessage(Message message)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteMessage(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<Message> GetMessage(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Message>> GetMessages()
        {
            throw new NotImplementedException();
        }
    }
}
