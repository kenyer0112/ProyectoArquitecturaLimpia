using CleanArchitectureHotelHome.Application.Interface;
using CleanArchitectureHotelHome.Domine;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureHotelHome.Infraestructura.Repositorios
{
    public class RoomRepository : IRoomRepositorio
    {
        private readonly HotelHomeDbContext _context;

        public RoomRepository(HotelHomeDbContext context)
        {
            _context = context;
        }

        public async Task<Room_D> CreateAsync(Room_D room)
        {
            await _context.Rooms.AddAsync(room);
            await _context.SaveChangesAsync();
            return room;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _context.Rooms.Where(model => model.Id == id).ExecuteDeleteAsync();
        }

        public async Task<List<Room_D>> GetAllAsync()
        {
            return await _context.Rooms.ToListAsync();
        }

        public async Task<Room_D> GetByIdAsync(int id)
        {
            return await _context.Rooms.AsNoTracking().FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task UpdateAsync(int id, Room_D room)
        {
            _context.Rooms.Update(room);
           await _context.SaveChangesAsync();
           
        }
    }
}
