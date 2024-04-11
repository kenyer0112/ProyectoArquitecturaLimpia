using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureHotelHome.Domine
{
    public class Reserva_D:EntityBase
    {
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
 
        public virtual Cliente_D Cliente { get; set; }

        public int RoomId { get; set; }
      
        public virtual Room_D Room { get; set; }

        public double TotalSubtotal { get; set; }

        public double Impuesto { get; set; }

        public double Descuento { get; set; }

        public double Total { get; set; }

        public DateTime FechaLLegada { get; set; }
        public DateTime FechaSalida { get; set; }

        public List<DetalleReserva_D> detalleReservas { get; set; }

        public List<Cliente_D> Clientes { get; set; }

        public List<Room_D> Rooms { get; set; }

    }
}
