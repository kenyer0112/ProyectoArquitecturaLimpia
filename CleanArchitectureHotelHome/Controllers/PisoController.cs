using CleanArchitectureHotelHome.Application.Piso.Create;
using CleanArchitectureHotelHome.Application.Piso.Delete;
using CleanArchitectureHotelHome.Application.Piso.Query.GetById;
using CleanArchitectureHotelHome.Application.Piso.Update;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureHotelHome.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PisoController : ApiControllerBase
    {
        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{
        //    var pisos = await Mediator.Send(new Get);
        //    return Ok(pisos);
        //}

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var piso = await Mediator.Send(new GetById() { Id = id });
            if (piso == null)
            {
                return NotFound();
            }

            return Ok(piso);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCommandPiso command)
        {
            var createdPiso = await Mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = createdPiso.Id }, createdPiso);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdatePisoCommand command)
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
            var result = await Mediator.Send(new DeletePisoCommand { Id = id });
            if (result == 0)
            {
                return BadRequest("Not Found");
            }
            return Ok("Eliminado con Exicto");
        }
    }
}
