using UserManager.Domain.Entities;
using UserManager.Domain.Interfaces;

namespace UserManager.Application.Features.Users
{
    public class UpdateUserUseCase
    {
        private readonly IUserRepository _userRepository;
        
        public UpdateUserUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Execute(Guid id, string name, string email)
        {
            User? user = _userRepository.GetById(id);
            if (user is null) throw new Exception("Usuario no encontrado");
            user.UpdateName(name);
            user.UpdateEmail(email);
        }

    }
}
