﻿using Microsoft.EntityFrameworkCore;

namespace ExploreCalifornia.Models
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public BlogDataContext(DbContextOptions<BlogDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
