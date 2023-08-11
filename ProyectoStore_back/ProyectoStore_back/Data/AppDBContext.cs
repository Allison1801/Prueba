using Microsoft.EntityFrameworkCore;
using ProyectoStore_back.Modelo;

namespace ProyectoStore_back.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        //mapeo de datos para realizar el crud
        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Producto> Producto { get; set; }
        public DbSet<Plan> Plan { get; set; }


        //Muestra la relacción entre el login y el usuario mediante la obtención del Id
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

        }
    }
}
