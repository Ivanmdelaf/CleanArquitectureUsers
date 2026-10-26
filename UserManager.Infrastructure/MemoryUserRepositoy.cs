using UserManager.Domain.Entities;
using UserManager.Domain.Interfaces;

namespace UserManager.Infrastructure
{
    public class MemoryUserRepositoy: IUserRepository
    {
        private static List<User> Users = [ new ("Iván", ""), new ("David", "")];

        public List<User> GetAll() {
            return Users;
        }

        public User? GetById(Guid id)
        {
             return Users.FirstOrDefault(x => x.Id == id);
        }

        public void Add(User user)
        {
            Users.Add(user);
        }

        public void DeleteById(Guid id)
        {
            User? userFinded = Users.FirstOrDefault(x => x.Id == id);
            if (userFinded is null) { throw new Exception("No existe ese usuario, para eliminarlo");  }
            Users.Remove(userFinded);
        }
        public void Delete(User user)
        {
            Users.Remove(user);
        }
    }
}
