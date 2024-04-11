using CleanArchitectureHotelHome.Application.Categoria.Command.Create;
using CleanArchitectureHotelHome.Application.Categoria.Command.Delete;
using CleanArchitectureHotelHome.Application.Categoria.Command.Update;
using CleanArchitectureHotelHome.Application.Categoria.Query.GetAll;
using CleanArchitectureHotelHome.Application.Categoria.Query.GetById;
using CleanArchitectureHotelHome.Infraestructura.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureHotelHome.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ApiControllerBase
    {
        private readonly ILogger<CategoriaRepository> _logger;

        public CategoriaController(ILogger<CategoriaRepository> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
        
            try
            {
                var categorys = await Mediator.Send(new GetCategoryQuery());
                return Ok(categorys);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ocurrió un error al realizar la tarea.");
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            _logger.LogInformation("Realizando el getByID.");
            try
            {
                var category = await Mediator.Send(new GetCategoryById() { Id = id });
                if (category == null)
                {
                    _logger.LogInformation("Categoria no existe");
                    return NotFound();
                }
                _logger.LogInformation("Realizdo con exito." + category.Name);
                return Ok(category);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "Ocurrió un error al realizar la tarea.");
                return BadRequest(ex);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateCommandCategory command)
        {
            try
            {
                var createdCategory = await Mediator.Send(command);
                _logger.LogInformation("Registro Realizdo con exito." + createdCategory.Name);
                return CreatedAtAction(nameof(GetById), new { id = createdCategory.Id }, createdCategory);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ocurrió un error al realizar la tarea.");
                return BadRequest(ex.Message);
            }
          
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, UpdateCategoryCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            await Mediator.Send(command);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            
            try
            {
                var result = await Mediator.Send(new DeleteCategoryCommand { Id = id });
                if (result == 0)
                {
                    return BadRequest("Not Found");
                }
                return Ok("Eliminado con Exicto");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ocurrió un error al Borrar");
                return BadRequest(ex.Message);
            }
        }

    }
}
