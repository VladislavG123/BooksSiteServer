using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoSite.Models
{
    public class User
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Photo> Photos { get; set; } = new List<Photo>();
    }
}