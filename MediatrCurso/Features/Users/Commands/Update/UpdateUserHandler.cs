using MediatR;
using MediatrCurso.Data;
using MediatrCurso.Models;
using Microsoft.EntityFrameworkCore;

namespace MediatrCurso.Features.Users.Commands.Update
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, bool>
    {
        private readonly AppDbContext _context;

        public UpdateUserHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            
            User user = await _context.Usuarios.FirstOrDefaultAsync(u => u.Id == request.id);

            if(user is null) return false;

            user.Nome = request.name;
            user.Sobrenome = request.sobreNome;
            user.Email = request.email;
            user.Cpf = request.cpf;
            
            _context.Usuarios.Update(user);
            await _context.SaveChangesAsync(cancellationToken);

            return true; 
        }
    }
}
