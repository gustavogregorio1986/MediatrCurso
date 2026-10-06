using MediatR;
using MediatrCurso.Features.Users.Commands.Create;
using MediatrCurso.Features.Users.Queries.GetAllUsers;
using MediatrCurso.Features.Users.Queries.GetUserById;
using Microsoft.AspNetCore.Mvc;

namespace MediatrCurso.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserCommand request)
        {
            var userId = await _mediator.Send(request);
            return  Created();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _mediator.Send(new GetAllUsersQuery());
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(new GetUserByIdQuery(id));

            if (result is null) return NotFound("Registro não encontrado!");

            return Ok(result);
        }
    }
}
