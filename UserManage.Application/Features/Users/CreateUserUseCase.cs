using UserManager.Domain.Entities;
using UserManager.Domain.Interfaces;

namespace UserManager.Application.Features.Users
{
    public class CreateUserUseCase
    {
        private readonly IUserRepository _userRepository;

        public CreateUserUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Guid Execute(string name, string email)
        {
            var newUser = new User(name, email);
            _userRepository.Add(newUser);
            return newUser.Id;
        }

    }
}
