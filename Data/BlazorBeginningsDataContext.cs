using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorBeginningsData.Models;

namespace BlazorBeginningsData.Data
{
    public class BlazorBeginningsDataContext : DbContext
    {
        public BlazorBeginningsDataContext (DbContextOptions<BlazorBeginningsDataContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorBeginningsData.Models.Movie> Movie { get; set; } = default!;
    }
}
