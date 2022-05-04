using Microsoft.EntityFrameworkCore;

namespace IssueTracker.Models {

    public class IssueTrackerDbContext :DbContext {

        public IssueTrackerDbContext(DbContextOptions<IssueTrackerDbContext> options) : base(options)
        {
            
        }

        public DbSet<Issue> Issues {get; set;} = null!;

    }

}