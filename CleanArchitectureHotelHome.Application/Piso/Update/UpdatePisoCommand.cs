using MediatR;

namespace CleanArchitectureHotelHome.Application.Piso.Update
{
    public class UpdatePisoCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Descripcion { get; set; }

        public int Stock { get; set; }
    }
}
