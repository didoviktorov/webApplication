using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_Site.Models
{
    public class Towns
    {
        [Key]
        public int TownId { get; set; }

        [StringLength(70)]
        public string TownName { get; set; }

        public virtual Listings Listing { get; set; }
    }
}