using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OLX.Data;
using OLX.Domain;
using Microsoft.EntityFrameworkCore;

namespace OLX.Repo
{
    public class MessageRepo : IMessageRepo
    {
        private readonly DataContext _context;
        public MessageRepo(DataContext context)
        {
            _context = context;
        }
        public async Task<bool> AddMessage(Message message)
        {
            if (message.Text == null)
            { return false; }
            else
            {
                message.Id = Guid.NewGuid();
                await _context.Messages.AddAsync(message);
                await _context.SaveChangesAsync();
                return true;
            }

        }

        public async Task<bool> DeleteMessage(Guid Id)
        {
            var message = await _context.Messages.FirstOrDefaultAsync(u => u.Id == Id);
            if (message == null)
            {
                return false;
            }
            else
            {
                _context.Messages.Remove(message);
                await _context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<List<Message>> GetMessages()
        {
            var messages = await _context.Messages.ToListAsync();
            if (messages == null)
                return null;
            return messages;
        }

        public async Task<Message> GetMessage(Guid Id)
        {
            var message = await _context.Messages.FirstOrDefaultAsync(u => u.Id == Id);

            return message;
        }

       
        
    }
}
