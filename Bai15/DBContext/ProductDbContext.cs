using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Bai15
{
    public class ProductDbContext
    {
        public ProductDbContext() : base("Server=localhost;Database=ProductMaster;User Id=sa;Password=123456") 
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<GroupAttribute> GroupAttributes { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
    }

}
