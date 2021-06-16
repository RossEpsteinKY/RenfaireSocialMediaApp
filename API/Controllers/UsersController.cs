using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {

            return Ok(await _userRepository.GetUsersAsync());

        }
        
        // [HttpGet("{id}")]
        // public async Task<ActionResult<AppUser>> GetUserByUsername(int id)
        // {
        //     // return await _context.Users.FindAsync(id);
        //     return await _userRepository.GetUserByIdAsync(id);
        // }
        
        [HttpGet("{username}")]
        public async Task<ActionResult<AppUser>> GetUserById(string username)
        {
            // return await _context.Users.FindAsync(id);
            return await _userRepository.GetUserByUsername(username);
        }
    }
}