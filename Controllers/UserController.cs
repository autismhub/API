using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data___User;
using API.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _repository;

        public UserController(IUserRepo repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Represent a method that performs a http GET request for a user with a specifik id
        /// </summary>
        /// <param name="id">Represent a a specifik user id</param>
        /// <returns></returns>
        [HttpGet("{id}", Name ="GetCommandById")]
        public ActionResult<UserReadDto> GetUserById(int id )
        {
            var UserItem = _repository.GetUserById(id);

            if (UserItem != null)
            {
                return Ok();
            }

            return NotFound();
        }

        /// <summary>
        /// Represent a method that performs a https GET request for every user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<UserReadDto>> GetAllUsers()
        {
            var UserItems = _repository.GetAllUsers();

            return Ok();
        }

        public ActionResult<UserReadDto> CreateUser(UserCreateDto userCreateDto)
        {
            var userModel = _mapper.Map<User>(userCreateDto);

            _repository.CreateUser(userModel);
            _repository.SaveChanges();

            var userReadDto = _mapper<UserReadDto>(userModel);

            return CreatedAtRoute(nameof(GetUserById), new { id = userReadDto.Id}, userReadDto);
        }


    }
}
