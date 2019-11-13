namespace PhotoSite.DataAccess
{
    using PhotoSite.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PhotoContext : DbContext
    {
        public PhotoContext()
            : base("name=PhotoContext")
        {
        }

        public DbSet<Photo> Photos { get; set; }
        public DbSet<User> Users { get; set; }
    }
}