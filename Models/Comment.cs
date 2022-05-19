using System;
using System.ComponentModel.DataAnnotations;

namespace AlkemyBlog.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [StringLength(300)]        
        public string Description { get; set; } = string.Empty;
        
        public User User { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
