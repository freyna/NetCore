using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace LeerData
{
    public class AppVentaCursosContext : DbContext
    {
        private const string connectionString = @"Data Source=192.168.0.30;Initial Catalog=CursosOnline;User Id=sa;Password=Kwn20191!";

        public DbSet<Curso> Curso {get;set;}
        public DbSet<Precio> Precio {get;set;}
        public DbSet<Comentario> Comentario {get;set;}
        public DbSet<Instructor> Instructor {get;set;}
        public DbSet<CursoInstructor> CursoInstructor {get;set;}
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        //Indicamos que la tabla tiene dos llaves primarias (llave compuesta)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CursoInstructor>()
            .HasKey(item =>
            new {
                item.CursoId
                ,item.InstructorId
                });
        }
    }
}