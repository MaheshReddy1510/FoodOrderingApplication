using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodOrderingApplication.Models
{
    public class FoodOrderingApplicationDb : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public Dbset<RestaurantReview> Reviews { get; set; }
    }

    public class DbSet<T>
    {
    }
}

    