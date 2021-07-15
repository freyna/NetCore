using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace LeerData
{
    public class AppVentaCursosContext : DbContext
    {
        private const string connectionString = @"Data Source=192.168.0.31;Initial Catalog=CursosOnline;User Id=sa;Password=Kwn20191!";

        public DbSet<Curso> Curso {get;set;}
        public DbSet<Precio> Precio {get;set;}
        public DbSet<Comentario> Comentario {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}