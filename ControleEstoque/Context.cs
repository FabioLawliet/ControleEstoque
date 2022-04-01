using System.Data.Entity;

namespace ControleEstoque1
{
    public class Context: DbContext
    {
        public Context() : base("BD")
        {
        }
        public DbSet<DtoProduto> produto { get; set; }
        public DbSet<DtoUsuario> usuario { get; set; }
    }
}
