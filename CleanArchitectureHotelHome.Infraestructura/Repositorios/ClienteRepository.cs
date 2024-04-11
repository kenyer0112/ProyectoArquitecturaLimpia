using CleanArchitectureHotelHome.Application.Interface;
using CleanArchitectureHotelHome.Domine;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureHotelHome.Infraestructura.Repositorios
{
    public class ClienteRepository : IClienteRepositorio
    {
        private readonly HotelHomeDbContext _context;

        public ClienteRepository(HotelHomeDbContext context)
        {
            _context = context;
        }

        public async Task<Cliente_D> CreateAsync(Cliente_D cliente)
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _context.Clientes.Where(model => model.Id == id).ExecuteDeleteAsync();
        }

        public async Task<List<Cliente_D>> GetAllAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente_D> GetByIdAsync(int id)
        {
            return await _context.Clientes.AsNoTracking().FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<int> UpdateAsync(int id, Cliente_D cliente)
        {
            _context.Clientes.Update(cliente).Property(x => x.Id).IsModified = false;
            return await _context.SaveChangesAsync();
        }
    }
}
