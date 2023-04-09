using blogger_server.Data;
using blogger_server.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace blogger_server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;
        public UserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUser()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<User>> UpdateUser(int id, User user)
        {
            if(id != user.Id)
            {
                return NotFound("Not Found!");
            }

            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok("Updated");
        }

        [HttpPost]
        public async Task<ActionResult<User>> AddUser(User user)
        {
            
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok("Added");

        }
    }
}
