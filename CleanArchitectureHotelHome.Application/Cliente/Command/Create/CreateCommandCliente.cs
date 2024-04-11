using CleanArchitectureHotelHome.Application.Cliente.Query;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureHotelHome.Application.Cliente.Command.Create
{
   public class CreateCommandCliente:IRequest<ClienteVM>
    {
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
