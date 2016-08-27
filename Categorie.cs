using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_Site.Models
{
    public partial class Categorie
    {
        [Required]
        public string CategorieName { get; set; }
        [Key]
        public Guid Id { get; set; }
        public virtual ICollection<Listings> Listing { get; set; }
    }
}