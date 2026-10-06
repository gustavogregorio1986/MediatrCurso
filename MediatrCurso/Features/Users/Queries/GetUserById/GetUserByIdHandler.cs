using MediatR;
using MediatrCurso.Data;
using MediatrCurso.Models;

namespace MediatrCurso.Features.Users.Queries.GetUserById
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, User>
    {
        private readonly AppDbContext _context;

        public GetUserByIdHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            User user = await _context.Usuarios.FindAsync(request.Id);
            return user;
        }
    }
}
