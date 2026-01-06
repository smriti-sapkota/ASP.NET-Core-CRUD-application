using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach.Models
{
    public class Student
    {
        [Key]//makes primary key in database
        public int Id { get; set; }

        [Column("StudentName", TypeName = "varchar(100)")]

        [Required]
        public string Name { get; set; }

        [Column("StudentGender", TypeName = "varchar(20)")]
        [Required]

        public string Gender { get; set; }

        [Column("StudentAge", TypeName = "int(20)")]
        [Required]
        public  int? Age { get; set; }

        [Required]
        public  int? Standard{ get; set; }
    }
}
