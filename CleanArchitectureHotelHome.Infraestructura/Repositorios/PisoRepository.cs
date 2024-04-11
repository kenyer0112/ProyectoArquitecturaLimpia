using CleanArchitectureHotelHome.Application.Interface;
using CleanArchitectureHotelHome.Domine;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureHotelHome.Infraestructura.Repositorios
{

    public class PisoRepository : IPisoRepositorio
    {
        private readonly HotelHomeDbContext _context;
        public PisoRepository(HotelHomeDbContext context)
        {
            _context = context;
        }

        public async Task<Piso_D> CreateAsync(Piso_D piso)
        {
            await _context.Pisos.AddAsync(piso);
            await _context.SaveChangesAsync();
            return piso;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _context.Pisos.Where(model => model.Id == id).ExecuteDeleteAsync();
        }

        public async Task<List<Piso_D>> GetAllCategoryssAsync()
        {
            return await _context.Pisos.ToListAsync();
        }

        public async Task<Piso_D> GetByIdAsync(int id)
        {
            return await _context.Pisos.AsNoTracking().FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<int> UpdateAsync(int id, Piso_D piso)
        {
            _context.Pisos.Update(piso).Property(x => x.Id).IsModified = false;
            return await _context.SaveChangesAsync();
        }
    }
}
