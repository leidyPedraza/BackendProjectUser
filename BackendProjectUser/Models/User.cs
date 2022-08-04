using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendProjectUser.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column( TypeName = "varchar(255)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Lastname { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Phone { get; set; }

    }
}
