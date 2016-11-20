using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcContacts.Models
{
    public class RestaurantViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Place { get; set; }
        public string RestaurantClass { get; set; }
        public RestaurantReview Reviews { get; set; }
        public ICollection<Restaurants> restaurants { get; set; }
    }
}