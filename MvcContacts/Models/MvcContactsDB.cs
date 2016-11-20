using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcContacts.Models
{
    public class MvcContactsDB : DbContext
    {
        public MvcContactsDB() : base("name=DefaultConnection")
        {

        }
        public DbSet<Restaurants> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }

    }
}