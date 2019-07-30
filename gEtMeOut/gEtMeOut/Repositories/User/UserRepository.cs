using System.Collections.Generic;
using System.Linq;
using gEtMeOut.Data;
using gEtMeOut.Models;

namespace gEtMeOut.Repositories
{
    public class UserRepository : IUserRepository
    {
        private DataContext db = new DataContext();

        public User AddUser(User user)
        {
            db.User.Add(user);
            db.SaveChanges();
            return user;
        }

        public List<User> AllUsers()
        {
            return db.User.ToList();
        }
    }
}
