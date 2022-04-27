using System.Data.Entity;

namespace MenuWebApp.Models
{
    public class CadastroContext : DbContext
    {

        public CadastroContext() : base("DbCadastroDePessoas")
    

    public DbSet<ClienteRest> Clientes { get; set; }
    public DbSet<PedidoRest> Pedidos { get; set; }
    public DbSet<CardapioRest> Cardapio { get; set; }

    }
}
