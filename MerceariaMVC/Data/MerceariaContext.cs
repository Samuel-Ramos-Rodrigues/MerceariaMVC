using Microsoft.EntityFrameworkCore;
using MerceariaMVC.Models;  
namespace MerceariaMVC.Data

{
    public class MerceariaContext:DbContext    
    {
        public MerceariaContext(DbContextOptions<MerceariaContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
