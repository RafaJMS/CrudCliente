using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudCliente.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        [EmailAddress(ErrorMessage = "Email Inválido")]
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Contato { get; set;}

    }
}
