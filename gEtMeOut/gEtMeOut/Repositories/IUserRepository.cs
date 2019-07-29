using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gEtMeOut.Models;

namespace gEtMeOut.Repositories
{
    public interface IUserRepository
    {
        List<User> AllUsers();

        User AddUser(User user);
    }
}
