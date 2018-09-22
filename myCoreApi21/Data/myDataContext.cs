using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myAspData.Models;

namespace myCoreApi21.Models
{
    public class myDataContext : DbContext
    {
        public myDataContext (DbContextOptions<myDataContext> options)
            : base(options)
        {
        }

        public DbSet<Session> Session { get; set; }
    }
}
