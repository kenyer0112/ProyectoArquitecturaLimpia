using AutoMapper;
using CleanArchitectureHotelHome.Application.Categoria.Query.GetById;
using CleanArchitectureHotelHome.Application.Piso.Query.GetById;
using CleanArchitectureHotelHome.Domine;
using CleanArchitectureHotelHome.Infraestructura.Repositorios;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureHotelHome.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ApiControllerBase
    {
        private  RoomRepository _repository;

        private IMapper _mapper;
        private readonly ILogger<RoomRepository> _logger;
        public RoomController(RoomRepository repository, IMapper mapper, ILogger<RoomRepository> logger)
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
                var obRoom = await _repository.GetByIdAsync(id);

                var roomDTo = _mapper.Map<RoomDTO>(obRoom);
                if (obRoom == null)
                {
                    _logger.LogInformation("Habitacion no existe");
                    return NotFound();
                }
                _logger.LogInformation("Realizdo con exito." + roomDTo.Estado);
                return Ok(roomDTo);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ocurrió un error al realizar la tarea.");
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoomDTO roomDTO)
        {
            try
            {
                var ObRoom = _mapper.Map<Room_D>(roomDTO);
                var category = await Mediator.Send(new GetCategoryById() { Id = ObRoom.CategoriaId });
                var piso = await Mediator.Send(new GetById() { Id = ObRoom.PisoId });
                if (category == null)
                {
                    return NotFound("Categoria no Existe");
                }
                if (piso == null)
                {
                    return NotFound("Piso no Existe");
                }
                var result = await _repository.CreateAsync(ObRoom);
                _logger.LogInformation("Registro Realizdo con exito." + result.Id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ocurrió un error al realizar la transaccion.");
                return BadRequest(ex.Message);
            }
        }



        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, RoomDTO roomDTO)
        {
            try
            {
                var oRoom = await _repository.GetByIdAsync(id);
                if (oRoom == null)
                {
                    return BadRequest("Producto no encontrado");
                }
                var room = _mapper.Map<Room_D>(roomDTO);

                oRoom.Precio = room.Precio <= 0 ? oRoom.Precio : room.Precio;
                oRoom.Estado = room.Estado is null ? oRoom.Estado : room.Estado;

                await _repository.UpdateAsync(id, oRoom);
                return Ok();

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
