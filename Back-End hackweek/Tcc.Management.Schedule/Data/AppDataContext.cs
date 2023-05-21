using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Tcc.Management.Schedule.Models;
using Tcc.Management.Schedule.Utils;

namespace Tcc.Management.Schedule.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {}

        public DbSet<Student> Students {get; set;}
        public DbSet<Supervisor> Supervisors {get; set;}
        public DbSet<User> Users { get; set;}   
        public DbSet<Meeting> Meetings { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = Configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
        }
    }
}