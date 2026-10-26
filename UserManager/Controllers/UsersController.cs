using Microsoft.AspNetCore.Mvc;
using UserManager.Application.Features.Users;
using UserManager.Application.Request;

namespace UserManager.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController :ControllerBase
    {
        private readonly GetUsersUseCase _getUserUseCase;
        private readonly CreateUserUseCase _createUserUseCase;

        public UsersController(GetUsersUseCase getUserUseCase, CreateUserUseCase createUserUseCase)
        {
            _getUserUseCase = getUserUseCase;
            _createUserUseCase = createUserUseCase;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _getUserUseCase.Execute();
            return Ok(users);
        }

        [HttpPost]
        public IActionResult CreateUser(CreateUserRequest request)
        {
            return Ok(_createUserUseCase.Execute(request.Name, request.Email));
        }

    }
}
