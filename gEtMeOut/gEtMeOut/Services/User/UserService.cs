using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gEtMeOut.Repositories;
using gEtMeOut.Models;

namespace gEtMeOut.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public User AddUser(User user)
        {
            return _userRepository.AddUser(user);
        }

        public List<User> GetUsers()
        {
            return _userRepository.AllUsers();
        }

    }
}
