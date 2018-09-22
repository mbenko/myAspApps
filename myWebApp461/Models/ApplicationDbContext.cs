using Microsoft.AspNet.Identity.EntityFramework;
using myAspData.Models;

namespace myWebApp461.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<Session> Sessions { get; set; }
    }
}