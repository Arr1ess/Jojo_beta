using Microsoft.EntityFrameworkCore;
using Startup_School_Jojo.Db.Modeks;

namespace Startup_School_Jojo.Db
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Plugin> Plugins { get; set; }
        public DbSet<Sample> Samples { get; set; }
        public DbSet<Workspace> Workspaces { get; set; }
        public DbSet<WorkspacePluginRelation> WorkspacePluginRelations { get; set; }
        public DbSet<UserWorkspaceRelation> UserWorkspaceRelations { get; set; }
        public DbSet<Friend> Friends { get; set; }
    }
}
