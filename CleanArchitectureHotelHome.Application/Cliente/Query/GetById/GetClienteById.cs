using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureHotelHome.Application.Cliente.Query.GetById
{
    public class GetClienteById:IRequest<ClienteVM>
    {
        public int Id { get; set; }
    }
}
