using CleanArchitectureHotelHome.Domine;

namespace CleanArchitectureHotelHome.Application.Interface
{
    public interface IRoolRepositorio
    {
        Task<List<Rool_D>> GetAllsAsync();
        Task<Rool_D> GetByIdAsync(int id);
        Task<Rool_D> CreateAsync(Rool_D rool);
        Task  UpdateAsync(int id, Rool_D rool);
        Task DeleteAsync(int id);
    }
}
