using CleanArchitectureHotelHome.Application.Mapping;
using CleanArchitectureHotelHome.Domine;

namespace CleanArchitectureHotelHome.Application.Cliente.Query
{
    public class ClienteVM : IMapFrom<Cliente_D>
    {
        public int Id { get; set; }

        public string Documento { get; set; }


        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }

        public string Sexo { get; set; }
    }
}
