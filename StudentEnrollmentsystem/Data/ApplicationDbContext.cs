using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using StudentEnrollmentsystem.Models.Entities;

namespace StudentEnrollmentsystem.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        public DbSet<Students> MyProperty { get; set; }
        public DbSet<Course> MyProperty1 { get; set; }
        public DbSet<Enrollment> MyProperty3 { get; set; }



    }
}
