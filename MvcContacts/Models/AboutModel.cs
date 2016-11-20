using MvcContacts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcContacts.Models
{
    public class AboutModel
    {
        public object Id { get; set; }
        public string Name { get; set; }
        public string Strasse { get; set; }
        public string Ort { get; set; }

    }
}