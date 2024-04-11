using CleanArchitectureHotelHome.Application.Cliente.Command.Create;
using CleanArchitectureHotelHome.Application.Cliente.Command.Delete;
using CleanArchitectureHotelHome.Application.Cliente.Command.Update;
using CleanArchitectureHotelHome.Application.Cliente.Query.GetAll;
using CleanArchitectureHotelHome.Application.Cliente.Query.GetById;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureHotelHome.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ApiControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var clientes = await Mediator.Send(new GetAllClienteQuery());
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cliente = await Mediator.Send(new GetClienteById() { Id = id });
            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCommandCliente command)
        {
            var createdCliente = await Mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = createdCliente.Id }, createdCliente);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateCommandCliente command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            await Mediator.Send(command);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await Mediator.Send(new DeleteClienteCommand { Id = id });
            if (result == 0)
            {
                return BadRequest("Not Found");
            }
            return Ok("Eliminado con Exicto");
        }


    }
}
