using App.Producer.Model;
using Microsoft.EntityFrameworkCore;

namespace App.Producer.Context
{
    public class KafkaContext  : DbContext
    {
        public DbSet<Person> Person { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer("Data Source=localhost,1433;Initial Catalog=TesteEF;User Id=sa;Password=123Aa321");
        }
    }
}