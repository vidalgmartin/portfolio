using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.Database;

namespace server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModelsController : ControllerBase
    {
        private readonly ServerDbContext _context;

        public ModelsController(ServerDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllModels()
        {
            var models = await _context.BlenderModels.ToListAsync();
            return Ok(models);
        }
    }
}
