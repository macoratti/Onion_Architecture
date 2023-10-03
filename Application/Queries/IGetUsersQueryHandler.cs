namespace Application.Queries;

public interface IGetUsersQueryHandler
{
    Task<List<UserResponse>?> Handle();
}
