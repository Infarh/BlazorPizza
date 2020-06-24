using Microsoft.EntityFrameworkCore;

namespace BlazorPizza.DAL.Context
{
    public class PizzaDB : DbContext
    {


        public PizzaDB(DbContextOptions<PizzaDB> options) : base(options) { }
    }
}
