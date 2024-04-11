using AutoMapper;
using CleanArchitectureHotelHome.Application.Interface;
using MediatR;

namespace CleanArchitectureHotelHome.Application.Cliente.Query.GetById
{
    public class GetClienteByIdHandler : IRequestHandler<GetClienteById, ClienteVM>
    {
        private readonly IClienteRepositorio _clienteRepository;
        private readonly IMapper _mapper;

        public GetClienteByIdHandler(IClienteRepositorio clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<ClienteVM> Handle(GetClienteById request, CancellationToken cancellationToken)
        {
            var cliente = await _clienteRepository.GetByIdAsync(request.Id);
            return _mapper.Map<ClienteVM>(cliente);
        }
    }
}
