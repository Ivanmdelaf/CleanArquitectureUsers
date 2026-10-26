
namespace UserManager.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;


        public User(string name, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
        }

        public void UpdateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("El nombre es obligatorio");

            Name = name;
        }

        public void UpdateEmail(string email)
        {
            Email = email;
        }

    }
}
