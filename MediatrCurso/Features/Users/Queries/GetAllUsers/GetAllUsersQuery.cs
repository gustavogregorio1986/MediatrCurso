using MediatR;
using MediatrCurso.Models;

namespace MediatrCurso.Features.Users.Queries.GetAllUsers
{
    public record GetAllUsersQuery() : IRequest<List<User>>;
}