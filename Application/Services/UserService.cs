using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public sealed class UserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Guid> CreateAsync(string name, string email)
    {
        var user = new User
        {
            Id = Guid.NewGuid(),
            Name = name,
            Email = email,
            CreatedOnUtc = DateTime.UtcNow
        };

        var userId = await _userRepository.InsertAsync(user);

        return userId;
    }

    public async Task UpdateUserAsync(Guid id, User user)
    {
        if (user is null)
            throw new ApplicationException("Invalid data");

        await _userRepository.UpdateAsync(user);
    }

    public async Task DeleteUserAsync(Guid id)
    {
        var user = await _userRepository.GetByIdAsync(id);

        if (user is null)
        {
            throw new ApplicationException("user not found");
        }
        await _userRepository.DeleteAsync(user);
    }
}
