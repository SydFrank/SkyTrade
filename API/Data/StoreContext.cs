using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

// This class is responsible for managing the connection to the database and providing access to the data through DbSet properties.
public class StoreContext(DbContextOptions options) : DbContext (options)
{
   public required DbSet<Product> Products { get; set; }
   
}
