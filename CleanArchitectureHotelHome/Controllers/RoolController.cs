using AutoMapper;
using CleanArchitectureHotelHome.Domine;
using CleanArchitectureHotelHome.Infraestructura.Repositorios;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureHotelHome.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoolController : ControllerBase
    {
        private  RoolRepository _repository;
        private IMapper _mapper;
        private readonly ILogger<RoolRepository> _logger;
        public RoolController(RoolRepository repository, IMapper mapper, ILogger<RoolRepository> logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            _logger.LogInformation("Realizando el getByID.");
            try
            {
                var obRool = await _repository.GetByIdAsync(id);

                var roolDTo = _mapper.Map<RoolDTO>(obRool);
                if (obRool == null)
                {
                    _logger.LogInformation("Rool no existe");
                    return NotFound();
                }
                _logger.LogInformation("Realizdo con exito.");
                return Ok(roolDTo);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ocurrió un error al realizar la tarea.");
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Create(RoolDTO roolDTO)
        {
            try
            {
                var ObRool = _mapper.Map<Rool_D>(roolDTO);


                var result = await _repository.CreateAsync(ObRool);
                _logger.LogInformation("Registro Realizado con exito.");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ocurrió un error al realizar la transaccion.");
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _repository.DeleteAsync(id);
                return Ok("Eliminado Correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ocurrió un error al Borrar");
                return BadRequest(ex);
            }
        }
    }
}
