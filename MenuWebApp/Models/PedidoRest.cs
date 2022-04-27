using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MenuWebApp.Models
{
    public class PedidoRest
    {
        [Key]
        [Display(Name = "Id")]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int IdPedido { get; set; }

        public int QPedito { get; set; }

        [ForeignKey("ClienteRest")]
        public int ClienteId { get; set; }
        public virtual ClienteRest Cliente { get; set; }
    }
}
