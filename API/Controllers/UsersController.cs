using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
        {

            var users = await _userRepository.GetMembersAsync();
            // var usersToReturn = _mapper.Map<IEnumerable<MemberDto>>(users);
            return Ok(users);

        }
        
        // [HttpGet("{id}")]
        // public async Task<ActionResult<AppUser>> GetUserByUsername(int id)
        // {
        //     // return await _context.Users.FindAsync(id);
        //     return await _userRepository.GetUserByIdAsync(id);
        // }
        
        [HttpGet("{username}")]
        public async Task<ActionResult<MemberDto>> GetUserById(string username)
        {
            // return await _context.Users.FindAsync(id);
            return await _userRepository.GetMemberAsync(username);
            // return _mapper.Map<MemberDto>(user);
        }
    }
}