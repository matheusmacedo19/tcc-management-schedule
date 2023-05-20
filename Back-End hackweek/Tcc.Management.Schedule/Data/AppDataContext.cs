using Microsoft.EntityFrameworkCore;
using Tcc.Management.Schedule.Models;

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
    }
}