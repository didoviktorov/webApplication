 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_Site.Models
{
    public class Listings
    {
        public  Listings()
        {
            this.Date=DateTime.Now;
            this.Files = new List<File>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title  { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string Author_Id { get; set; }

        [ForeignKey("Author_Id")]
        public ApplicationUser Author { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<File> Files { get; set; }

        public virtual IEnumerator<Categorie> Categories { get; set; }
        public string CategorieName { get; set; }
    }
}