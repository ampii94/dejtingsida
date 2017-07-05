using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class SearchModel
    {
        public string SearcgString { get; set; }
        public string SignedInUser { get; set; }
        public List<User> Result { get; set; }
    }
}