﻿using BlazorBattles.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorBattles.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext( DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Unit> Units { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
