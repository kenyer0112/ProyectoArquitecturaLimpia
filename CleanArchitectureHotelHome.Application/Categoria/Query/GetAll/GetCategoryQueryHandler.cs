using AutoMapper;
using CleanArchitectureHotelHome.Application.Interface;
using MediatR;

namespace CleanArchitectureHotelHome.Application.Categoria.Query.GetAll
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, List<CategoriaVM>>
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;
        private readonly IMapper _mapper;

        public GetCategoryQueryHandler(ICategoriaRepositorio categoriaRepositorio, IMapper mapper)
        {
            _categoriaRepositorio = categoriaRepositorio;
            _mapper = mapper;
        }
        public async Task<List<CategoriaVM>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {

            var categorys = await _categoriaRepositorio.GetAllCategoryssAsync();
            var cateList = _mapper.Map<List<CategoriaVM>>(categorys);
            return cateList;
        }
    }
}
