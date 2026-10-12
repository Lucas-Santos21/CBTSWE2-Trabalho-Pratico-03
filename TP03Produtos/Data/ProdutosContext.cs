//Nome e prontuário da dupla:
//Lucas da Silva Santos CB3030598
//Kaueh Farias Ferreira dos Santos CB3031438

using Microsoft.EntityFrameworkCore;
using TP03Produtos.Models;

namespace TP03Produtos.Data
{
    public class ProdutosContext : DbContext
    {
        public ProdutosContext(DbContextOptions<ProdutosContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; } = null!;
    }
}
