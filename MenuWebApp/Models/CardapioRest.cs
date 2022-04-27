using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MenuWebApp.Models
{
    public class CardapioRest
    {
        [Key]
        [Display(Name = "Id")]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int IdPrato { get; set; }

        public int CodigoPrato { get; set; }

        public string NomePrato { get; set; }

        public decimal Preco { get; set; }

        public virtual PedidoRest Pedido { get; set; }
    }
}
