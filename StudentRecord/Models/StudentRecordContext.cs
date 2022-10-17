using EAS.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
namespace StudentRecord.Models
{
    public class StudentRecordContext:DbContext
    {
        protected readonly IConfiguration Configuration;

        public StudentRecordContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings
            
            var connString = Configuration.GetConnectionString("DefaultConnectionMySql");
            options.UseMySql(connString, ServerVersion.AutoDetect(connString));
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Address> Addresses { get; set; }

    }
}
