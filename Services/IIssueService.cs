

using IssueTracker.Models;

namespace IssueTracker.Services {


    public interface IIssueService
    {

         public Issue GetIssue();

         public void AddIssue(Issue issue);


         public List<Issue> GetAllIssues();
         

    }


}