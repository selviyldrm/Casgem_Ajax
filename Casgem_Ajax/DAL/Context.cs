using Microsoft.EntityFrameworkCore;

namespace Casgem_Ajax.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-U4DC5DI;initial catalog=CasgemAjax1Db;integrated Security=true");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
