using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using magalu_notify.src.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace magalu_notify.src.Infra;

public class AppDbContext : DbContext
{

    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Channel> Channel { get; set; }
    public DbSet<Status> Status { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        const string connectionString = "Server=localhost;Database=magalu_notify;User=jpdev;Password=12345678;";
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
}