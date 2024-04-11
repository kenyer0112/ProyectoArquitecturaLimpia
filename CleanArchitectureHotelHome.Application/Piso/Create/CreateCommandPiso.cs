
using CleanArchitectureHotelHome.Application.Piso.Command;
using MediatR;

namespace CleanArchitectureHotelHome.Application.Piso.Create
{
    public class CreateCommandPiso : IRequest<PisoVM>
    {
        public string Name { get; set; }

        public string Descripcion { get; set; }

        public int Stock {  get; set; }
    }
}
