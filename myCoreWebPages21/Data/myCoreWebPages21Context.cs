using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myAspData.Models;


namespace myCoreWebPages21.Models
{
    public class myCoreWebPages21Context : DbContext
    {
        public myCoreWebPages21Context (DbContextOptions<myCoreWebPages21Context> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }

        public DbSet<myAspData.Models.Session> Session { get; set; }

    }
}
