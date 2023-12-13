using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Unit_testing.Data;
using Unit_testing.Dtos;

namespace Unit_testing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserDbContext _context;

        public UserController(UserDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            var result = await _context.Users.ToListAsync();
            return Ok(result);
        }

        
    }
}
