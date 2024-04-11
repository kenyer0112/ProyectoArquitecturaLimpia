using CleanArchitectureHotelHome.Application.Interface;
using CleanArchitectureHotelHome.Domine;
using MediatR;

namespace CleanArchitectureHotelHome.Application.Piso.Update
{
    public class UpdateCommandHandler : IRequestHandler<UpdatePisoCommand, int>
    {
        private readonly IPisoRepositorio _pisoRepositorio;
        public UpdateCommandHandler(IPisoRepositorio pisoRepositorio)
        {
            _pisoRepositorio = pisoRepositorio;
        }

        public async Task<int> Handle(UpdatePisoCommand request, CancellationToken cancellationToken)
        {
            var updateEntity = new Piso_D()
            {
                Id = request.Id,
                Name = request.Name,
                Descripcion = request.Descripcion,
                Stock = request.Stock


            };

            return await _pisoRepositorio.UpdateAsync(request.Id, updateEntity);
        }
    }
}
