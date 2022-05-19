using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AlkemyBlog.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(80)]       
        public string Name { get; set; } = string.Empty;
               
        public string Email { get; set; } = string.Empty;
        
        public string Password { get; set; } = string.Empty;

        public ICollection<Post> Posts { get; set; } = null!;

        public ICollection<Comment> Comments { get; set; } = null!;
    }
}
