using CleanArchitectureHotelHome.Domine;

namespace CleanArchitectureHotelHome.Application.Interface
{
    public interface IPisoRepositorio
    {
        Task<List<Piso_D>> GetAllCategoryssAsync();
        Task<Piso_D> GetByIdAsync(int id);
        Task<Piso_D> CreateAsync(Piso_D piso);
        Task<int> UpdateAsync(int id, Piso_D piso);
        Task<int> DeleteAsync(int id);
    }
}
