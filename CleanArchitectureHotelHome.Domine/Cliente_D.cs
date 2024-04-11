using System.ComponentModel.DataAnnotations;

namespace CleanArchitectureHotelHome.Domine
{
    public class Cliente_D : EntityBase
    {

        [Required]
        public string Documento { get; set; }
        [Required]
        [MaxLength(300)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(300)]
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [MaxLength(13)]
        public string Telefono { get; set; }
        [MaxLength(14)]
        public string Sexo { get; set; }
    }
}
