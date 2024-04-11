using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureHotelHome.Application.Cliente.Command.Update
{
    public class UpdateCommandCliente:IRequest<int>
    {
        public int Id { get; set; }

        public string Documento { get; set; }


        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }

        public string Sexo { get; set; }
    }
}
