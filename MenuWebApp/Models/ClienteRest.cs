using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MenuWebApp.Models
{
    public class ClienteRest
    {
        [Key]
        [Display (Name ="Id")]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Nome do Cliente")]
        [Required(ErrorMessage = "Esse Campo é de preenchimento obrigatório")]
        public string NomeCliente { get; set; }

        public virtual List<PedidoRest> Pedidos { get; set; }

      
    }
}
