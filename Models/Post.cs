using System;
using System.ComponentModel.DataAnnotations;


namespace AlkemyBlog.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }        

        [StringLength(80)]        
        public string Title { get; set; } = string.Empty;

        [StringLength(300)]        
        public string Content { get; set; } = string.Empty;
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public User User { get; set; }
    }
}
