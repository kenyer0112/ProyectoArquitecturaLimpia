using CleanArchitectureHotelHome.Application.Piso.Command;
using MediatR;

namespace CleanArchitectureHotelHome.Application.Piso.Query.GetById
{
    public class GetById : IRequest<PisoVM>
    {
        public int Id { get; set; }
    }
}
