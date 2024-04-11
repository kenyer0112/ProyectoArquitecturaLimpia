using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureHotelHome.Application.Categoria.Query.GetById
{
    public class GetCategoryById:IRequest<CategoriaVM>
    {
        public int Id { get; set; }
    }
}
