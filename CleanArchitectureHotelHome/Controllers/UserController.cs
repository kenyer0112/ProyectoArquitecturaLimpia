using AutoMapper;
using CleanArchitectureHotelHome.Application.Categoria.Query.GetById;
using CleanArchitectureHotelHome.Application.Piso.Query.GetById;
using CleanArchitectureHotelHome.Domine;
using CleanArchitectureHotelHome.Domine.DTOs;
using CleanArchitectureHotelHome.Infraestructura.Repositorios;
using Domain.DTOs;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureHotelHome.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserRopository _repository;
        private RoolRepository _roolRepository;
        private IMapper _mapper;
        public UserController(UserRopository repository,IMapper mapper, RoolRepository roolRepository)
        {
            _repository = repository;
            _mapper = mapper;
            _roolRepository = roolRepository;
        }
        [HttpGet("{id:int}")]

        public async Task<IActionResult> GetById(int id)
        {
          
            try
            {
                var obUser = await _repository.GetByIdAsync(id);

                var UserDTo = _mapper.Map<UserDTO>(obUser);
                if (obUser == null)
                {
                  
                    return NotFound();
                }
           
                return Ok(UserDTo);
            }
            catch (Exception ex)
            {
               
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserDTO userDTO)
        {
            try
            {
                var ObUser = _mapper.Map<User_D>(userDTO);

                var rool = await _roolRepository.GetByIdAsync(ObUser.RoolId);

                if (rool==null)
                {
                    return NotFound("El Rool no Existe");
                }
                var result = await _repository.CreateAsync(ObUser);
              
                return Ok(result);
            }
            catch (Exception ex)
            {
               
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, UserUpdateDTO userDTO)
        {
            try
            {
                var oUser = await _repository.GetByIdAsync(id);
                if (oUser == null)
                {
                    return BadRequest("User no encontrado");
                }
                var user = _mapper.Map<UserUpdateDTO>(userDTO);

                oUser.Fullname = user.Fullname is null ? oUser.Fullname : user.Fullname;
                oUser.LoginName = user.LoginName is null ? oUser.LoginName : user.LoginName;
                oUser.Email = user.Email is null ? oUser.Email : user.Email;
                oUser.Password = user.Password is null ? oUser.Password : user.Password;

                await _repository.UpdateAsync(id, oUser);
                return Ok();

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
