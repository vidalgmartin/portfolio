using Microsoft.EntityFrameworkCore;
using server.Models;

namespace server.Database
{
    public class ServerDbContext : DbContext
    {
        public ServerDbContext(DbContextOptions<ServerDbContext> options) : base(options) { }

        public DbSet<BlenderModel> BlenderModels { get; set; }
    }
}
