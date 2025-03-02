using Microsoft.EntityFrameworkCore;
using LastWebTaskW3D1.Models;
using System.Collections.Generic;

namespace LastWebTaskW3D1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
