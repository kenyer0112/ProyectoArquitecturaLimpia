using CleanArchitectureHotelHome.Application.Interface;
using CleanArchitectureHotelHome.Domine;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureHotelHome.Infraestructura.Repositorios
{
    public class RoolRepository : IRoolRepositorio
    {
        private readonly HotelHomeDbContext _context;

        public RoolRepository(HotelHomeDbContext context)
        {
            _context = context;
        }
        public async Task<Rool_D> CreateAsync(Rool_D rool)
        {
            await _context.Rool.AddAsync(rool);
            await _context.SaveChangesAsync();
            return rool;
        }

        public async Task DeleteAsync(int id)
        {
            await _context.Rool.Where(model => model.Id == id).ExecuteDeleteAsync();
        }



        public async Task<List<Rool_D>> GetAllsAsync()
        {
            return await _context.Rool.ToListAsync();
        }

        public async Task<Rool_D> GetByIdAsync(int id)
        {
            return await _context.Rool.AsNoTracking().FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task  UpdateAsync(int id, Rool_D rool)
        {
            _context.Rool.Update(rool);
            await _context.SaveChangesAsync();
        }
    }
}
