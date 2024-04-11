using AutoMapper;
using CleanArchitectureHotelHome.Application.Interface;
using MediatR;

namespace CleanArchitectureHotelHome.Application.Cliente.Query.GetAll
{
    public class GetAllClienteQueryHandler : IRequestHandler<GetAllClienteQuery, List<ClienteVM>>
    {
        private readonly IClienteRepositorio _clienteRepository;
        private readonly IMapper _mapper;

        public GetAllClienteQueryHandler(IClienteRepositorio clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<List<ClienteVM>> Handle(GetAllClienteQuery request, CancellationToken cancellationToken)
        {
            var clientes = await _clienteRepository.GetAllAsync();
            var clienList = _mapper.Map<List<ClienteVM>>(clientes);
            return clienList;
        }
    }
}
