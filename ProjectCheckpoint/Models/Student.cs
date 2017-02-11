using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectCheckpoint.Models
{
    [Table("students")]
    public class Student
    {
        [Column("student_id")]
        [Key]
        public int StudentId { get; set; }

        [Column("rfid_id")]
        [Required]
        public byte[] RfidId { get; set; }

        [Column("surname")]
        [Required]
        public string Surname { get; set; }

        [Column("name")]
        [Required]
        public string Name { get; set; }

        [Column("patronymic")]
        [Required]
        public string Patronymic { get; set; }

        [Column("iin")]
        [Required]
        public string IIN { get; set; }

        [Column("photo")]
        [Required]        
        public byte[] Photo { get; set; }        
    }
}
