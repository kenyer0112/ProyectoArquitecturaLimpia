using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureHotelHome.Domine
{
   public class Piso_D:EntityBase
    {
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(300)]
        public string Descripcion { get; set; }

        public int Stock { get; set; }
        //public DateTime Fecha { get; set; }

        //public virtual ICollection<Room> Rooms { get; set; }
    }
}
