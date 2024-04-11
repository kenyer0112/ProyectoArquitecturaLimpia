using AutoMapper;
using CleanArchitectureHotelHome.Domine;

using Domain.DTOs;

namespace CleanArchitectureHotelHome.Infraestructura.Profiles
{
    public class AutoMappingProfile : Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<Room_D, RoomDTO>().ReverseMap();

            CreateMap<Rool_D, RoolDTO>().ReverseMap();

            CreateMap<User_D, UserDTO>().ReverseMap();


        }
    }
}
