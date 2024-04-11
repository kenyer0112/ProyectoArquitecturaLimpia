using AutoMapper;
using CleanArchitectureHotelHome.Application.Cliente.Query;
using CleanArchitectureHotelHome.Application.Interface;
using CleanArchitectureHotelHome.Domine;
using MediatR;

namespace CleanArchitectureHotelHome.Application.Cliente.Command.Create
{
    public class CreateCommandHandler : IRequestHandler<CreateCommandCliente, ClienteVM>
    {
        private readonly IClienteRepositorio _clienteRepository;
        private readonly IMapper _mapper;
        public CreateCommandHandler(IClienteRepositorio clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<ClienteVM> Handle(CreateCommandCliente request, CancellationToken cancellationToken)
        {
            var clienteEntity = new Cliente_D() { Documento = request.Documento, Nombre = request.Nombre, Apellido = request.Apellido, FechaNac = request.FechaNac, Email = request.Email, Telefono = request.Telefono, Sexo = request.Sexo };
            var result = await _clienteRepository.CreateAsync(clienteEntity);
            return _mapper.Map<ClienteVM>(result);

        }
    }
}
