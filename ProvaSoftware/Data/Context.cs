using Microsoft.EntityFrameworkCore;
using ProvaSoftware.Data.Models;

namespace ProvaSoftware.Data;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }

    public DbSet<FolhaDePagamento> FolhaPagamento { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<FolhaDePagamento>().HasKey(m => m.Id);
        base.OnModelCreating(builder);
    }
}