using AutoMapper;
using CleanArchitectureHotelHome.Application.Interface;
using CleanArchitectureHotelHome.Application.Piso.Command;
using CleanArchitectureHotelHome.Domine;
using MediatR;

namespace CleanArchitectureHotelHome.Application.Piso.Create
{
    public class CreateCommandHandler : IRequestHandler<CreateCommandPiso, PisoVM>
    {
        private readonly IPisoRepositorio _pisoRepositorio;
        private readonly IMapper _mapper;
        public CreateCommandHandler(IPisoRepositorio pisoRepositorio, IMapper mapper)
        {
            _pisoRepositorio = pisoRepositorio;
            _mapper = mapper;
        }

        public async Task<PisoVM> Handle(CreateCommandPiso request, CancellationToken cancellationToken)
        {
            var pisoEntity = new Piso_D() { Name = request.Name, Descripcion = request.Descripcion, Stock = request.Stock };
            var result = await _pisoRepositorio.CreateAsync(pisoEntity);
            return _mapper.Map<PisoVM>(result);
        }
    }
}
