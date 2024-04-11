using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureHotelHome.Domine
{
    public class DetalleReserva_D:EntityBase
    {
        [Required]
        public int ReservaId { get; set; }
        // [ForeignKey("ReservaId")]
        public Reserva_D Reserva { get; set; }
        [Required]
        public double Precio { get; set; }
        [Required]
        public int RoomId { get; set; }
        //[ForeignKey("RoomId")]
        public Room_D Room { get; set; }
        public int CantidadNoche { get; set; }
        public double Descuento { get; set; }

        public double SubTotal
        {
            get; set;
        }

        public double Impuesto
        {
            get; set;
        }


        public double Total
        {
            get; set;

        }

    }
}
