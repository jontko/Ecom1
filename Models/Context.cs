using Microsoft.EntityFrameworkCore;

namespace Ecom1.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
    }
}