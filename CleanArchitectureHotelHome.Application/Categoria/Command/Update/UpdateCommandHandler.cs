using CleanArchitectureHotelHome.Application.Interface;
using CleanArchitectureHotelHome.Domine;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureHotelHome.Application.Categoria.Command.Update
{
    public class UpdateCommandHandler : IRequestHandler<UpdateCategoryCommand, int>
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public UpdateCommandHandler(ICategoriaRepositorio categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }
        public async Task<int> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var updateEntity = new Categoria_D()
            {
                Id = request.Id,
                Name = request.Name,
                Descripcion = request.Descripcion
            };

            return await _categoriaRepositorio.UpdateAsync(request.Id, updateEntity);
        }
    }
}
