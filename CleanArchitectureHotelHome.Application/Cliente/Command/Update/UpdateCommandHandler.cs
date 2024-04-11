using CleanArchitectureHotelHome.Application.Interface;
using CleanArchitectureHotelHome.Domine;
using MediatR;

namespace CleanArchitectureHotelHome.Application.Cliente.Command.Update
{
    public class UpdateCommandHandler : IRequestHandler<UpdateCommandCliente, int>
    {
        private readonly IClienteRepositorio _clienteRepository;

        public UpdateCommandHandler(IClienteRepositorio clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<int> Handle(UpdateCommandCliente request, CancellationToken cancellationToken)
        {
            var clienteEntity = new Cliente_D() {Id=request.Id, Documento = request.Documento, Nombre = request.Nombre, Apellido = request.Apellido, FechaNac = request.FechaNac, Email = request.Email, Telefono = request.Telefono, Sexo = request.Sexo };
            return await _clienteRepository.UpdateAsync(request.Id, clienteEntity);
        }
    }
}
