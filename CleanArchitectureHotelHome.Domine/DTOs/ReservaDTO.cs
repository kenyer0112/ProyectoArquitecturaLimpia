using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class ReservaDTO
    {
      

        public DateTime Fecha { get; set; }

        public ClienteDTO Cliente { get; set; }

        public RoomDTO Room { get; set; }

        public double TotalSubtotal { get; set; }

        public double Impuesto { get; set; }

        public double Descuento { get; set; }

        public double Total { get; set; }

        public DateTime FechaLLegada { get; set; }
        public DateTime FechaSalida { get; set; }

        public List<DetalleReservaDTO> detalleReservas { get; set; }

    }
}
