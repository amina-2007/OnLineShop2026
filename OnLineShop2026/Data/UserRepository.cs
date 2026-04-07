using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public class UserRepository
    {
        List<User> users=new List<User>();

        public List<User> GetAll()
        {
            return users;
        }

        public User? TryGetById(Guid id)
        {
            return users.FirstOrDefault(product => product.Id == id);
        }
    }
}
