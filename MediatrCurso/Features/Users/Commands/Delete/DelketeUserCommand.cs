using MediatR;

namespace MediatrCurso.Features.Users.Commands.Delete
{
    public record DeleteUserCommand(int id) : IRequest<bool>;
}
