using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace trackingapi.Models
{
    public class Issue
    {
        public int Id { get; set; }
        [Required]
        public Guid Guid { get; set; }
        [Required]
        public string? Title { get; set; }
                       
        public string? Description { get; set; }
        public Priority Priority { get; set; }
        public IssueType IssueType { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Completed { get; set; }
        public DateTime? Modified  { get; set; }

        [ForeignKey("Users")]
        public int Userid { get; set; } 
        public virtual User Users { get; set; }


    }

    public enum Priority
    { 
    low, high , medium
    }
    public enum IssueType
    {
        bug, Documentation , Feature 
    
    }
}
