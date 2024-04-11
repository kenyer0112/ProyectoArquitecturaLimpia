using CleanArchitectureHotelHome.Application.Interface;
using MediatR;

namespace CleanArchitectureHotelHome.Application.Cliente.Command.Delete
{
    public class DeleteCommandHandler : IRequestHandler<DeleteClienteCommand, int>
    {
        private readonly IClienteRepositorio _clienteRepository;

        public DeleteCommandHandler(IClienteRepositorio clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<int> Handle(DeleteClienteCommand request, CancellationToken cancellationToken)
        {
            return await _clienteRepository.DeleteAsync(request.Id);
        }
    }
}
