using CleanArchitectureHotelHome.Application.Interface;
using CleanArchitectureHotelHome.Domine;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureHotelHome.Infraestructura.Repositorios
{
    public class CategoriaRepository : ICategoriaRepositorio
    {
        private readonly HotelHomeDbContext _context;

        public CategoriaRepository(HotelHomeDbContext context)
        {
            _context = context;
        }

        public async Task<Categoria_D> CreateAsync(Categoria_D categoria)
        {
            await _context.Categorias.AddAsync(categoria);
            await _context.SaveChangesAsync();
            return categoria;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _context.Categorias.Where(model => model.Id == id).ExecuteDeleteAsync();
        }



        public async Task<List<Categoria_D>> GetAllCategoryssAsync()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async Task<Categoria_D> GetByIdAsync(int id)
        {
            return await _context.Categorias.AsNoTracking().FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<int> UpdateAsync(int id, Categoria_D categoria)
        {
            //return await _context.Categorias.Where(model => model.Id == id)
            //    .ExecuteUpdateAsync(setter => setter
            //        .SetProperty(m => m.Id, categoria.Id)
            //         .SetProperty(m => m.Name, categoria.Name)
            //         .SetProperty(m => m.Descripcion, categoria.Descripcion)

            //        ).IsModified = false;
            _context.Categorias.Update(categoria).Property(x => x.Id).IsModified = false;
            return await _context.SaveChangesAsync();
        }
    }
}
