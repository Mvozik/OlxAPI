using OLX.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLX.Repo
{
    interface IMessageRepo
    {
        Task<List<Message>> GetMessages();
        Task<Message> GetMessage(Guid Id);
        Task<bool> DeleteMessage(Guid Id);
        Task<bool> AddMessage(Message message);
    }
}
