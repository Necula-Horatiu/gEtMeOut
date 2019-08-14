using System.Collections.Generic;
using gEtMeOut.Models;

namespace gEtMeOut.Repositories
{
    public interface IUserRepository
    {
        List<User> AllUsers();

        User AddUser(User user);

        User LoginUser(User user);
    }
}
