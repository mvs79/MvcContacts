﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcContacts.Models
{
    public class RestaurantReview
    {
        public int Id { get; set; }
        //[Required]
        //[Range(1,10)]
        public int Rating { get; set; }
        //[Required]
        //[StringLength(1024)]
        public int Body { get; set; }
        public string RestaurantReviewer { get; set; }
        public Restaurants Restaurant { get; set; }
      
    }
}