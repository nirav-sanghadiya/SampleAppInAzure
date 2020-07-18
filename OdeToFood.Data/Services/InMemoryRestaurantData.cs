using OdeToFood.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Dominoz Piza",Cuisine = CuisinType.Italian },
                new Restaurant { Id = 2, Name = "Barbeque Nation",Cuisine = CuisinType.Indian },
                new Restaurant { Id = 3, Name = "The French tate",Cuisine = CuisinType.French }
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r=>r.Name);
        }
    }
}
