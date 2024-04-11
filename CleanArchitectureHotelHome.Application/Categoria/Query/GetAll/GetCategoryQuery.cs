using MediatR;

namespace CleanArchitectureHotelHome.Application.Categoria.Query.GetAll
{
    public class GetCategoryQuery : IRequest<List<CategoriaVM>>
    {
    }
}
