using Microsoft.EntityFrameworkCore;

namespace ChefsAndDishes.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) {}
        // Remember to add the models you need for your database
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Dish> Dishes { get; set; }
    }
}