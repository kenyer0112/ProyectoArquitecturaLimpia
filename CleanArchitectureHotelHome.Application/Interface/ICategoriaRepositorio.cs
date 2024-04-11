using CleanArchitectureHotelHome.Domine;

namespace CleanArchitectureHotelHome.Application.Interface
{
    public interface ICategoriaRepositorio
    {
        Task<List<Categoria_D>> GetAllCategoryssAsync();
        Task<Categoria_D> GetByIdAsync(int id);
        Task<Categoria_D> CreateAsync(Categoria_D categoria);
        Task<int> UpdateAsync(int id, Categoria_D categoria);
        Task<int> DeleteAsync(int id);
    }
}
