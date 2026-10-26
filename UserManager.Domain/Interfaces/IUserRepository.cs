

using UserManager.Domain.Entities;

namespace UserManager.Domain.Interfaces
{
    public interface IUserRepository
    {
        public List<User> GetAll();
        public User? GetById(Guid id);
        public void Add(User user);
        public void DeleteById(Guid id);
        public void Delete(User user);

    }
}
