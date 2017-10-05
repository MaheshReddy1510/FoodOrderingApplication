using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodOrderingApplication.Models
{
    public class OdeToFoodDb :DbContext
    {
        public Dbset<Restaurant> Restaurants { get; set; }
        public Dbset<RestaurantReview> Reviews { get; set; }
    }

    public class Dbset<T>
    {
    }
}