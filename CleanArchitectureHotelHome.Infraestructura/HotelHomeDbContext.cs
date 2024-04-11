using CleanArchitectureHotelHome.Domine;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureHotelHome.Infraestructura
{
    public class HotelHomeDbContext : DbContext
    {
     

        public HotelHomeDbContext(DbContextOptions<HotelHomeDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
      
        public DbSet<Categoria_D> Categorias { get; set; }
        public DbSet<Cliente_D> Clientes { get; set; }
        public DbSet<Piso_D> Pisos { get; set; }
        public DbSet<User_D> Users { get; set; }

        public DbSet<Rool_D> Rool { get; set; }
        public DbSet<Room_D> Rooms { get; set; }

        public DbSet<Reserva_D> Reserva { get; set; }
        public DbSet<DetalleReserva_D> detalleReserva { get; set; }


    }
}
