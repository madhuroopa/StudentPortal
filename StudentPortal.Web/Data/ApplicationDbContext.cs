using Microsoft.EntityFrameworkCore;
using StudentPortal.Web.Models.Entities;

namespace StudentPortal.Web.Data
{
    //Dbcontext class acts as a bridge betweek ER core and database will be able to talk to sql

    /// server tables through this class

    public class ApplicationDbContext : DbContext
    {
        //ctor and tab for constructor
        //this constructor uses the program.cs file where it has the dbcontext options and inject it into the Application db context
        //DbSet is a class that represents an entity set that can be used for database operations. It is typically used within a DbContext class to define a
        //collection of entities that can be queried and saved to the underlying database.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
               
        
        }
        public DbSet<Student> Students { get; set; }

    }
 } 

