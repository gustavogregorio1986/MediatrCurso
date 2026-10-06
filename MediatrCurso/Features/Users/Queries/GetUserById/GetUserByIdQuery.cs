using MediatR;
using MediatrCurso.Models;

namespace MediatrCurso.Features.Users.Queries.GetUserById
{
    public record GetUserByIdQuery(int Id) : IRequest<User>;
}
