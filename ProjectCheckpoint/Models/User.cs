using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ProjectCheckpoint.Models
{
    [Table("users")]
    public class User
    {
        [Column("user_id")]
        [Key]
        public int UserId { get; set; }

        [Column("login")]
        [Required]        
        public string Login { get; set; }

        [Column("password")]
        [Required]
        public string Password { get; set; }
    }
}
