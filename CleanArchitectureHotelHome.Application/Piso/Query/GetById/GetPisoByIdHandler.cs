using AutoMapper;
using CleanArchitectureHotelHome.Application.Interface;
using CleanArchitectureHotelHome.Application.Piso.Command;
using MediatR;

namespace CleanArchitectureHotelHome.Application.Piso.Query.GetById
{
    public class GetPisoByIdHandler : IRequestHandler<GetById, PisoVM>
    {
        private readonly IPisoRepositorio _pisoRepositorio;
        private readonly IMapper _mapper;
        public GetPisoByIdHandler(IPisoRepositorio pisoRepositorio, IMapper mapper)
        {
            _pisoRepositorio = pisoRepositorio;
            _mapper = mapper;
        }

        public async Task<PisoVM> Handle(GetById request, CancellationToken cancellationToken)
        {
            var piso = await _pisoRepositorio.GetByIdAsync(request.Id);
            return _mapper.Map<PisoVM>(piso);
        }
    }
}
