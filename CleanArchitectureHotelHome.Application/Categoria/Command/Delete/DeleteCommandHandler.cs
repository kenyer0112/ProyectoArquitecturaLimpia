using CleanArchitectureHotelHome.Application.Interface;
using MediatR;

namespace CleanArchitectureHotelHome.Application.Categoria.Command.Delete
{
    public class DeleteCommandHandler : IRequestHandler<DeleteCategoryCommand, int>
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public DeleteCommandHandler(ICategoriaRepositorio categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }

        public async Task<int> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            return await _categoriaRepositorio.DeleteAsync(request.Id);
        }
    }
}
