using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id = 1, Name = "soroosh", Location = "tehran", Cuisine = CuisineType.Iran},
                new Restaurant{Id = 2, Name = "ahmad", Location = "qom", Cuisine = CuisineType.Italian},
                new Restaurant{Id = 3, Name = "asgar", Location = "karaj", Cuisine = CuisineType.Mexican},
                new Restaurant{Id = 4, Name = "leyla", Location = "karaj", Cuisine = CuisineType.Italian},
                new Restaurant{Id = 5, Name = "mohammad", Location = "ahvaz", Cuisine = CuisineType.Mexican},
            };
        }
        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in restaurants
                        where string.IsNullOrEmpty(name) || r.Name.StartsWith(name) 
                        orderby r.Name
                        select r;
        }
    }
}