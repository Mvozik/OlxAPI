using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using OLX.Domain;

namespace OLX.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        public virtual DbSet<Advert> Adverts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Subcategory> Subcategories { get; set; }
        public virtual DbSet<User> Users { get; set; }

    }
}
