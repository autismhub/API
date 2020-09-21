using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data___User;
using API.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using API.Models;

namespace API.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _repository;
        private readonly IMapper _mapper;

        public UserController(IUserRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Represent a method that performs a http GET request for a user with a specifik id
        /// </summary>
        /// <param name="id">Represent a a specifik user id</param>
        /// <returns></returns>
        /// api/user/{id}
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
        /// Represent a method that performs a http GET request for every user
        /// </summary>
        /// <returns></returns>
        /// /api/user
        [HttpGet]
        public ActionResult<IEnumerable<UserReadDto>> GetAllUsers()
        {
            var UserItems = _repository.GetAllUsers();

            return Ok(_mapper.Map<IEnumerable<UserReadDto>>(UserItems));
        }

        /// <summary>
        /// Represent a method that performs a http POST request to create a new user
        /// </summary>
        /// <param name="userCreateDto">Represent the user object</param>
        /// <returns></returns>
        /// /api/user
        public ActionResult<UserReadDto> CreateUser(UserCreateDto userCreateDto)
        {
            var userModel = _mapper.Map<User>(userCreateDto);

            _repository.CreateUser(userModel);
            _repository.SaveChanges();

            var userReadDto = _mapper.Map<UserReadDto>(userModel);

            return CreatedAtRoute(nameof(GetUserById), new { id = userReadDto.Id}, userReadDto);
        }


    }
}
