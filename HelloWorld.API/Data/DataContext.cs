using HelloWorld.API.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloWorld.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Greeting> Greetings { get; set; }
    }
}