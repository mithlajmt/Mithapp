using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using OwnApp.Models;

namespace OwnApp.Contexts
{
    public class StudentsContext : DbContext
    {
        public StudentsContext(DbContextOptions<StudentsContext> options) :base(options)  { } // This argument provides configuration options for the database context, such as the connection string to the database.
        //The : base(options) part of the line calls the constructor of the base class (DbContext) and passes the options argument to it.This ensures that the base class is initialized correctly with the provided configuration options. 
        public DbSet<StudentModel> Students { get; set; } //DBset For Students
    }

}
