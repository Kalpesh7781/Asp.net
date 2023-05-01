using Microsoft.EntityFrameworkCore;
using StudentCrud.Models;
using System.Data.Common;

namespace StudentCrud.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        
        }
        
        public DbSet<Student> Student { get; set; }    
    }
}
