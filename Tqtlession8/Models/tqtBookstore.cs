using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tqtlession8.Models
{
    public class tqtBookstore:DbContext
    {
        public tqtBookstore() : base()
        {

        }
        public DbSet<tqtCategory> tqtCategories { get; set; }
        public DbSet<tqtBook> tqtBooks { get; set; }

    }
}