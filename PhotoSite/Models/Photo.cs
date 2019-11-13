using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoSite.Models
{
    public class Photo
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public virtual User User { get; set; }
    }
}