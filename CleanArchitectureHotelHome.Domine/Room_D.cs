using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureHotelHome.Domine
{
    public class Room_D:EntityBase
    {
        public decimal Precio { get; set; }
        [MaxLength(100)]
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
        public int CategoriaId { get; set; }
        //[ForeignKey("CategoriaId")]
        public virtual Categoria_D Categoria { get; set; }
        public int PisoId { get; set; }
        //[ForeignKey("PisoId")]
        public virtual Piso_D Piso { get; set; }
    }
}
