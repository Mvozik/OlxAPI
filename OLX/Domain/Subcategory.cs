using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLX.Domain
{
    public class Subcategory
    {
        public Guid Id { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public bool Iscompany { get; set; }
    }
}
