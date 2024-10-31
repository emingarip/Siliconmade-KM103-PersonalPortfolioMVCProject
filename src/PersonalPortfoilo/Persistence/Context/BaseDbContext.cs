using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context;

public class BaseDbContext : DbContext
{
    protected IConfiguration Configuration { get; set; }
    public DbSet<AboutUser> AboutUsers { get; set; }
    public DbSet<BlogComments> BlogComments { get; set; }
    public DbSet<BlogPosts> BlogPosts { get; set; }
    public DbSet<ContactFormMessages> ContactFormMessages { get; set; }
    public DbSet<UserExperiences> UserExperiences { get; set; }
    public DbSet<UserProjects> UserProjects { get; set; }

    public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
    {
        Configuration = configuration;
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}
