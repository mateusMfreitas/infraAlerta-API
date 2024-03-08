using Microsoft.EntityFrameworkCore;
using infraAlerta.Models;

namespace infraAlerta.Data{
    public class ApiDbContext : DbContext {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options){

        }
        public DbSet<User> User { get; set;}
    }
}