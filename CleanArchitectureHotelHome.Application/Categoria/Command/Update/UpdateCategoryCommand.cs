using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureHotelHome.Application.Categoria.Command.Update
{
    public class UpdateCategoryCommand:IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
    }
}
