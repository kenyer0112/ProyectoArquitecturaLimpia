using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class DetalleReservaDTO
    {
     
        public ReservaDTO Reserva { get; set; }
        public double Precio { get; set; }
        public RoomDTO Room { get; set; }
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
