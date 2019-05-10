using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SSS_System.Models;

namespace SSS_System.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Technician> Technicians { get; set; }

        public DbSet<ExpertiseField> Expertisefields { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Installation> Installations { get; set; }

        public DbSet<Job> Jobs { get; set; }
        
        public DbSet<Area> Areas { get; set; }


    }
}