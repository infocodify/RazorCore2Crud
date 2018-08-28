using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorCrudCore2.Models
{
    public class ApplicationDbContext : DbContext
    {
        //Implement the constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //add Book table to the database
        public DbSet<Book> Books { get; set; }

    }
}
