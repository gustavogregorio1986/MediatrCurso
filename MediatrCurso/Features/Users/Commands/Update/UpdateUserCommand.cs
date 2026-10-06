using MediatR;

namespace MediatrCurso.Features.Users.Commands.Update
{
    public record UpdateUserCommand(int id, string name, string sobreNome, string email, string cpf) : IRequest<bool>;
}
