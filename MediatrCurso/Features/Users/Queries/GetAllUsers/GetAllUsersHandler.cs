using MediatR;
using MediatrCurso.Data;
using MediatrCurso.Models;
using Microsoft.EntityFrameworkCore;

namespace MediatrCurso.Features.Users.Queries.GetAllUsers
{
    public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, List<User>>
    {
        private readonly AppDbContext _context;

        public GetAllUsersHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return await _context.Usuarios.ToListAsync();
        }
    }
}
