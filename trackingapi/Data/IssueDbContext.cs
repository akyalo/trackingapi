using trackingapi.Models;

namespace trackingapi.Data
{
    public class IssueDbContext : DbContext 
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options)
            :base(options)
        { 
        }

       
        public DbSet<User> Users { get; set; }
        public DbSet<Issue> Issues { get; set; }


    }
}
