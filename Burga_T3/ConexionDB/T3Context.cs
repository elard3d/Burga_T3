using Burga_T3.Models;
using Microsoft.EntityFrameworkCore;

namespace Burga_T3.ConexionDB
{
    public class T3Context: DbContext
    {
       public DbSet<Usuario> Usuarios { get; set; }
       public DbSet<Registro> Registros { get; set; }
        public T3Context(DbContextOptions<T3Context> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new RegistroMap());
            
        }
    }
}