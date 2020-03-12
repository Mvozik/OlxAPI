using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLX.Domain
{
    public class Advert
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Localization { get; set; }
        public bool Iscompany { get; set; }
        public virtual Category Category { get; set; }

    }
}

