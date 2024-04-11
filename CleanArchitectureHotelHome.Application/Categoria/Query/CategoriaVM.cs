using CleanArchitectureHotelHome.Application.Mapping;
using CleanArchitectureHotelHome.Domine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureHotelHome.Application.Categoria.Query
{
    public class CategoriaVM:IMapFrom<Categoria_D>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Descripcion { get; set; }

    }
}
