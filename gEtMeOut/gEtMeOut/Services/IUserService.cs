using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gEtMeOut.Models;

namespace gEtMeOut.Services
{
    public interface IUserService
    {
        List<User> GetUsers();

        User AddUser(User user);
    }
}
