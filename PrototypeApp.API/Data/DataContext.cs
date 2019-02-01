using Microsoft.EntityFrameworkCore;
using PrototypeApp.API.Models;

namespace PrototypeApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }

        //table name in DB will be *Values* that can inherit the fields from *Value* Class
        public DbSet<Value> Values { get; set; }  
        
    }
}