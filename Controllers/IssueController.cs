using IssueTracker.Models;
using IssueTracker.Services;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers
{
    [Route("api/[controller]")]
    public class IssueController : Controller
    {
   
        private readonly IIssueService _issueService;
        public IssueController(IIssueService issueService)
        {
            _issueService=issueService;
        }

        [HttpGet]
        public Issue GetIssue()
        {

            
            return  _issueService.GetIssue();
        }

        [HttpGet("all")]
        public List<Issue> GetIssues()
        {
            return  _issueService.GetAllIssues();
        }

         [HttpPost]
        public void AddIssue(Issue issue)
        {

            
           _issueService.AddIssue(issue);
        }
    }


}