namespace IssueTracker.Models
{

public class Issue{

    public int Id { get; set; }
    public string? Description { get; set; }

    public DateTime dateEntered {get; set; } 

    public bool IsComplete {get; set;}
}
}