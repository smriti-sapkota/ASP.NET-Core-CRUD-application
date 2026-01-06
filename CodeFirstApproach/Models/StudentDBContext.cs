using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproach.Models
{
    public class StudentDBContext : DbContext //base is used to call the parent class constructor
    {
        public StudentDBContext(DbContextOptions options): base(options)//constructor = class name
        {
            
        }

        public  DbSet<Student> Students { get; set; } //Represents table data with name Students
    }
}
