using Microsoft.EntityFrameworkCore;
using webapi_Learning.Models;

namespace webapi_Learning.Data
{
    public class apiDbcs: DbContext
    {
        public apiDbcs(DbContextOptions options) : base(options)
        { }
        public DbSet<webapi>? webapis { get; set; }

    }
}
