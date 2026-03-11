using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Database
{
    public class eCommerceContext : DbContext
    {
        public eCommerceContext(DbContextOptions<eCommerceContext> options) : base(options) 
        {

          
        
        
        }  
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Contato> Contato { get; set; }
        public DbSet<EnderecoEntrega> EnderecoEntregas { get; set; }
        public DbSet<Departartamento> Departartamentos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBeCommerce;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False");
        }

    }
}
