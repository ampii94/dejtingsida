using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ProfileModel
    {
        public User User { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<User> Friends { get; set; }
        public int isFriends { get; set; }

    }
}