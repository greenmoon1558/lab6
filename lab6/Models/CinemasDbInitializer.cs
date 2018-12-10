using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace lab6.Models
{
    public class CinemasDbInitializer : DropCreateDatabaseAlways<CinemaContext>
    {
        protected override void Seed(CinemaContext db)
        {
            db.Countries.Add(new Country { Name = "Ukraine" });
            db.Cities.Add(new City { Name = "Kyiv" , Counrty= "Ukraine", Id = 1 });
            db.Cinemas.Add(new Cinema { Name = "Kino", City="Kyiv", Address="Address" , Id = 1});
            db.Cinemas.Add(new Cinema { Name = "Kino2", City = "Kyiv", Address = "Address2", Id = 2 });
            db.Cinemas.Add(new Cinema { Name = "Kino3", City = "Kyiv", Address = "Address3", Id = 3 });
            db.Cinemas.Add(new Cinema { Name = "Kino4", City = "Kyiv", Address = "Address4", Id = 4 });

            base.Seed(db);
        }
    }
}