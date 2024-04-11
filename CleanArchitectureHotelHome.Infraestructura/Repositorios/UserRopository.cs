using CleanArchitectureHotelHome.Application.Interface;
using CleanArchitectureHotelHome.Domine;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureHotelHome.Infraestructura.Repositorios
{
    public class UserRopository : IUserRepositorio
    {
        private readonly HotelHomeDbContext _context;

        public UserRopository(HotelHomeDbContext context)
        {
            _context = context;
        }
        public async Task<User_D> CreateAsync(User_D user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task DeleteAsync(int id)
        {
            await _context.Users.Where(model => model.Id == id).ExecuteDeleteAsync();
        }

        public async Task<List<User_D>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User_D> GetByIdAsync(int id)
        {
            return await _context.Users.AsNoTracking().FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task UpdateAsync(int id, User_D user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
