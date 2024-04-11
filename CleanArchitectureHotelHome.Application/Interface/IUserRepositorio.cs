using CleanArchitectureHotelHome.Domine;

namespace CleanArchitectureHotelHome.Application.Interface
{
    public interface IUserRepositorio
    {
        Task<List<User_D>> GetAllAsync();
        Task<User_D> GetByIdAsync(int id);
        Task<User_D> CreateAsync(User_D user);
        Task UpdateAsync(int id, User_D user);
        Task DeleteAsync(int id);
    }
}
