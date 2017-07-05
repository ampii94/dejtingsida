using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class LoggedInModel
    {
        public string Email { get; set; }
        public List<User> UserList { get; set; }
    }
}