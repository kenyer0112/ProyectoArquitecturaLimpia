using MediatR;

namespace CleanArchitectureHotelHome.Application.Cliente.Command.Delete
{
    public class DeleteClienteCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
