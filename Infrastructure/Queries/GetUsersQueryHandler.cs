using Application.Queries;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Queries;

public class GetUsersQueryHandler : IGetUsersQueryHandler
{
    private readonly AppDbContext _dbContext;

    public GetUsersQueryHandler(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<List<UserResponse>?> Handle()
    {
        var users = await _dbContext.Users.AsNoTracking()
                          .Select(user => new UserResponse
                          {
                              Id = user.Id,
                              Name = user.Name,
                              Email = user.Email
                          }).ToListAsync();
        return users;
    }
}
