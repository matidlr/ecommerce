using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data
{
    internal class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) 
{ 
    ´public DbSet<Product> Products { get; set }

    }
}
