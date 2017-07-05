using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class FriendRequestModel
    {
        public List<User> UserRelatedToRequests { get; set; }
    }
}