using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data___User
{
    public class MockUserRepo : IUserRepo
    {
        public void CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            var user = new List<User>
            {
                new User{Id = 0, Firstname = "Patrick", Lastname = "Star", Username = "patricktest" ,Password = "Passw0rd", Phonenumber = "123456789", Email = "test@test.com", Address = "test city"},
                new User{Id = 1, Firstname = "Spongebob", Lastname = "Squarepants", Username = "spongebobtest" ,Password = "Passw0rd", Phonenumber = "123456789", Email = "test@test.com", Address = "test city"},
                new User{Id = 2, Firstname = "Sandy", Lastname = "Cheeks", Username = "sandytest" ,Password = "Passw0rd", Phonenumber = "123456789", Email = "test@test.com", Address = "test city"}
                
            };

            return user;
        }

        public User GetUserById(int id)
        {
            return new User { Id = 0, Firstname = "Patrick", Lastname = "Star", Username = "patricktest", Password = "Passw0rd", Phonenumber = "123456789", Email = "test@test.com", Address = "test city" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
