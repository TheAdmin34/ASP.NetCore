using AcdYoklama.Models.DbEntities;
using Microsoft.EntityFrameworkCore;

namespace AcdYoklama.DAL
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Yoklamas { get; set; }
        public DbSet<Yoklama> Yoklama { get; set;}
    }
}
