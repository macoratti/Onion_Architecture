namespace Application.Queries;

public interface IGetUserByIdQueryHandler
{
    Task<UserResponse?> Handle(Guid id);
}
