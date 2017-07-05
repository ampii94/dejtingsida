using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class FriendRequestModel
    {
        public List<User> UsersRelatedToRequests { get; set; }
    }
}