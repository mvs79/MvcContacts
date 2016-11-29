using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcContacts.Models
{
    public class Restaurants
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Street { get; set; }
        public virtual string Place { get; set; }
        public virtual string RestaurantClass { get; set; }
        public virtual ICollection<RestaurantReview> Reviews{ get; set; }
    }
}