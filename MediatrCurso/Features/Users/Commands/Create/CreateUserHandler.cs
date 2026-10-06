using MediatR;
using MediatrCurso.Data;
using MediatrCurso.Models;
using Microsoft.EntityFrameworkCore;

namespace MediatrCurso.Features.Users.Commands.Create
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly AppDbContext _context;

        public CreateUserHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            // Mapeia o comando para a entidade User
            var user = new User
            {
                Nome = request.Nome,
                Sobrenome = request.Sobrenome,
                Email = request.Email,
                Cpf = request.CPF
            };

            _context.Usuarios.Add(user);

            // Salva as alterações de forma assíncrona corretamente
            await _context.SaveChangesAsync(cancellationToken);

            // Retorna o ID gerado pelo banco
            return user.Id;
        }
    }
}