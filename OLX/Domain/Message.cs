using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLX.Domain
{
    public class Message
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
    }
}
