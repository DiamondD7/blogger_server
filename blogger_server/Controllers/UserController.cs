using blogger_server.Data;
using blogger_server.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace blogger_server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController
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

        /*[HttpPut("{id}")]
        public async Task<ActionResult<User>> UpdateUser(int id)
        {
            var findUser = await _context.users.FindAsync(id);
            if(findUser == null)
            {
                return 
            }
        }*/
    }
}
