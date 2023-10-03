using Domain.Entities;

namespace Domain.Interfaces;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(Guid id);
    Task<Guid> InsertAsync(User user);
    Task UpdateAsync(User user);
    Task DeleteAsync(User user);
}
