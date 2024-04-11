using CleanArchitectureHotelHome.Domine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureHotelHome.Application.Interface
{
    public interface IRoomRepositorio
    {
        Task<List<Room_D>> GetAllAsync();
        Task<Room_D> GetByIdAsync(int id);
        Task<Room_D> CreateAsync(Room_D room);
        Task UpdateAsync(int id, Room_D room);
        Task<int> DeleteAsync(int id);
    }
}
