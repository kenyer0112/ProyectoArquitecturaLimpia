using AutoMapper;
using CleanArchitectureHotelHome.Application.Interface;
using MediatR;

namespace CleanArchitectureHotelHome.Application.Categoria.Query.GetById
{
    public class GetCategoryByIdHandler : IRequestHandler<GetCategoryById, CategoriaVM>
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;
        private readonly IMapper _mapper;

        public GetCategoryByIdHandler(ICategoriaRepositorio categoriaRepositorio, IMapper mapper)
        {
            _categoriaRepositorio = categoriaRepositorio;
            _mapper = mapper;
        }
        public async Task<CategoriaVM> Handle(GetCategoryById request, CancellationToken cancellationToken)
        {
            var category = await _categoriaRepositorio.GetByIdAsync(request.Id);
            return _mapper.Map<CategoriaVM>(category);
        }
    }
}
