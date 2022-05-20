using System.ComponentModel.DataAnnotations;

namespace IssueTracker.Models
{

public class Issue{

    [Key]
    public int Id { get; set; }

    [Required]
    public string? Description { get; set; }

    public DateTime dateEntered {get; set; }  = DateTime.UtcNow;

    public bool IsComplete {get; set;} = false;
}
}