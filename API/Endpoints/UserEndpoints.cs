using Application.Queries;
using Application.Services;
using Domain.Entities;

namespace API.Endpoints;

public static class UserEndpoints
{
    public static void MapUserEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapPost("api/users", async (CreateUserRequest request, UserService useService) =>
        {
            var userId = await useService.CreateAsync(
                request.Name,
                request.Email);

            return Results.Ok(userId);
        });

        app.MapPut("api/users/{id}", async (Guid id, User request,UserService userService) =>
        {
            if (id != request.Id)
                return Results.BadRequest();

            await userService.UpdateUserAsync(id, request);

            return Results.NoContent();
        });

        app.MapDelete("api/users/{id}", async (Guid id, UserService userService) =>
        {
            await userService.DeleteUserAsync(id);

            return Results.NoContent();
        });

        app.MapGet("api/users/{id}", async (Guid id, IGetUserByIdQueryHandler handler) =>
        {
            var user = await handler.Handle(id);

            return user is null ? Results.NotFound() : Results.Ok(user);
        });

        app.MapGet("api/users", async (IGetUsersQueryHandler handler) =>
        {
            var users = await handler.Handle();

            return users is null ? Results.NotFound() : Results.Ok(users);
        });
    }
}
