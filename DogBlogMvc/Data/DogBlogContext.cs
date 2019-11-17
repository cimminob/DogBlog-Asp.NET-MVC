using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DogBlogMvc.Models;

namespace DogBlogMvc.Data
{
    public class DogBlogContext : DbContext
    {
        public DogBlogContext(DbContextOptions<DogBlogContext> options)
    : base(options)
        {
        }

        public DbSet<Dog> Dogs { get; set; }
    }
}
