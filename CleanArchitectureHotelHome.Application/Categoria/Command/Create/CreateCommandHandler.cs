using AutoMapper;
using CleanArchitectureHotelHome.Application.Categoria.Query;
using CleanArchitectureHotelHome.Application.Interface;
using CleanArchitectureHotelHome.Domine;
using MediatR;

namespace CleanArchitectureHotelHome.Application.Categoria.Command.Create
{
    public class CreateCommandHandler : IRequestHandler<CreateCommandCategory, CategoriaVM>
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;
        private readonly IMapper _mapper;
        public CreateCommandHandler(ICategoriaRepositorio categoriaRepositorio, IMapper mapper)
        {
            _categoriaRepositorio = categoriaRepositorio;
            _mapper = mapper;
        }
        public async Task<CategoriaVM> Handle(CreateCommandCategory request, CancellationToken cancellationToken)
        {
            var categoryEntity = new Categoria_D() { Name = request.Name, Descripcion = request.Descripcion };
            var result = await _categoriaRepositorio.CreateAsync(categoryEntity);
            return _mapper.Map<CategoriaVM>(result);
        }
    }
}
