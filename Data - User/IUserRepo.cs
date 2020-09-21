using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data___User
{
    interface IUserRepo
    {
        IEnumerable<User> GetAllUsers();

        User GetUserById(int id);

        void CreateUser(User user);

        bool SaveChanges();
    }
}
