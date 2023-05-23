using DataAccess.Domain;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        //public DbSet<Cliente> Clientes { get; set; }
        public DbSet<TbCliente> TbClientes { get; set; }
        public DbSet<TbEndereco> TbClienteEnderecos { get; set; }
        public DbSet<TbCidade> TbCidades { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public AppDbContext()
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-LSEMRNN;Initial Catalog=Carrefour_Atacadao;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
