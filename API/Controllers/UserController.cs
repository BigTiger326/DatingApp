using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;

        }
        [HttpGet]
        public async Task<  ActionResult<IEnumerable<AppUser>>> GetUsers()
        {


            var user = await _context.Users.ToListAsync();
            return user;

        }
        [HttpGet("{id}")]
        public async Task< ActionResult<AppUser>> GetUser(int id)
        {

            return  await _context.Users.FindAsync(id);
     
        }



    }
}