using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreCalifornia.Models;
using Microsoft.EntityFrameworkCore;

namespace ExploreCalifornia.Views.Blog
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
}
