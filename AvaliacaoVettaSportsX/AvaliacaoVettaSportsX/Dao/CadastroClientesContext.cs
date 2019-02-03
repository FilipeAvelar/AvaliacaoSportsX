using AvaliacaoVettaSportX.Models;
using System.Data.Entity;

namespace AvaliacaoVettaSportX.Dao
{
    public class CadastroClientesContext : DbContext
    {
        public CadastroClientesContext() :
            base("clientesContext")
        {

        }

        public DbSet<Cliente> cliente { get; set; }
    }
}