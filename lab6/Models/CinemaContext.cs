using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;

namespace lab6.Models
{
    public class CinemaContext: DbContext
    {
            public DbSet<Cinema> Cinemas { get; set; }
            public DbSet<City> Cities { get; set; }
            public DbSet<Country> Countries { get; set; }

    }
}