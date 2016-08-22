using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web_Site.Models
{
    public class Comment
    {
        public DbSet<Comment> Comments { get; set; }
        public Comment()
        {
            this.Date = DateTime.Now;
        }
        [Required]
        [Key]
        public int CommentId { get; set; }
        [Required]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string AuthorId { get; set; }
        public virtual ApplicationUser Author { get; set; }
        public int EventId { get; set; }
    }
}