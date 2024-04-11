using CleanArchitectureHotelHome.Application.Categoria.Query;
using MediatR;

namespace CleanArchitectureHotelHome.Application.Categoria.Command.Create
{
    public class CreateCommandCategory : IRequest<CategoriaVM>
    {
        public string Name { get; set; }

        public string Descripcion { get; set; }
    }
}
