using Microsoft.EntityFrameworkCore;
using Versta.Models;

namespace Versta.DataAccess;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Order> Order { get; set; }

}