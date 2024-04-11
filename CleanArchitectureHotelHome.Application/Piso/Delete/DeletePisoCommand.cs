using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureHotelHome.Application.Piso.Delete
{
    public class DeletePisoCommand:IRequest<int>
    {
        public int Id { get; set; }
    }
}
