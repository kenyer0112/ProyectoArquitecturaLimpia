namespace Domain.DTOs
{
    public class RoomDTO
    {


        public decimal Precio { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }

        public int CategoriaId { get; set; }

        public int PisoId { get; set; }

        //public int Capacidad { get; set; }

    }
}
