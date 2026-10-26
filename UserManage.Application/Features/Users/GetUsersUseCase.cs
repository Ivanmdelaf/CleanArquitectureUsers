
using UserManager.Application.DTOs;
using UserManager.Domain.Entities;
using UserManager.Domain.Interfaces;

namespace UserManager.Application.Features.Users
{
    public class GetUsersUseCase
    {
        private readonly IUserRepository _userRepository;

        public GetUsersUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserDto> Execute()
        {
            return _userRepository.GetAll().Select(user => new UserDto { Id = user.Id, Name = user.Name, Email = user.Email}).ToList();
        }

    }
}
