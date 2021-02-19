using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    [Table("Usuario", Schema = "dbo")]
    public class Usuario
    {
        [Key]
        public decimal usuID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
    }
}
