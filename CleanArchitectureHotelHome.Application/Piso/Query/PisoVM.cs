using CleanArchitectureHotelHome.Application.Mapping;
using CleanArchitectureHotelHome.Domine;

namespace CleanArchitectureHotelHome.Application.Piso.Command
{
    public class PisoVM : IMapFrom<Piso_D>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Descripcion { get; set; }

        public int Stock { get; set; }

    }
}
