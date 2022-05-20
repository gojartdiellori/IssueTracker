using IssueTracker.Models;

namespace IssueTracker.Services {

    public class IssueService : IIssueService
    {
        private readonly IssueTrackerDbContext _dbContext;
        public IssueService(IssueTrackerDbContext dbContext)
        {
            _dbContext=dbContext;
        }
        public void AddIssue(Issue issue)
        {
           _dbContext.Add<Issue>(issue);
           _dbContext.SaveChanges();
        }

        public List<Issue> GetAllIssues()
        {
            return _dbContext.Issues.ToList();
        }

        public Issue GetIssue()
        {
           Issue issue = new Issue{ Description = "Issuaee"} ;

           return issue;
        }
    }


}