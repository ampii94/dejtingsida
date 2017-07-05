using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class IndexLoggedInUserModel
    {
        public string Email { get; set; }
        public List<User> userList { get; set; }
    }
}