using CleanArchitectureHotelHome.Application.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureHotelHome.Application.Piso.Delete
{
    public class DeleteCommandHandler:IRequestHandler<DeletePisoCommand,int>
    {
        private readonly IPisoRepositorio _pisoRepositorio;

        public DeleteCommandHandler(IPisoRepositorio pisoRepositorio)
        {
            _pisoRepositorio = pisoRepositorio;
        }

        public async Task<int> Handle(DeletePisoCommand request, CancellationToken cancellationToken)
        {
            return await _pisoRepositorio.DeleteAsync(request.Id);
        }
    }
}
