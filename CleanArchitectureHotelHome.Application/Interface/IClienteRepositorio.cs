using CleanArchitectureHotelHome.Domine;

namespace CleanArchitectureHotelHome.Application.Interface
{
    public interface IClienteRepositorio
    {
        Task<List<Cliente_D>> GetAllAsync();
        Task<Cliente_D> GetByIdAsync(int id);
        Task<Cliente_D> CreateAsync(Cliente_D cliente);
        Task<int> UpdateAsync(int id, Cliente_D cliente);
        Task<int> DeleteAsync(int id);
    }
}
