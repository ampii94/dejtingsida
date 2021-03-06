﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    using System;
    using System.Collections.Generic;
    public class User
    {
        public virtual int UserId { get; set;}
        public virtual string Email { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Password { get; set; }
        public virtual string About { get; set; }
        public virtual string PictureUrl { get; set; }
        public virtual string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

        public virtual bool Visible { get; set; }

        public virtual ICollection<Post> PostsRecieved { get; set; }
        public virtual ICollection<Post> PostsSent { get; set; }
        public virtual ICollection<Friend> RequestsRecieved { get; set; }
        public virtual ICollection<Friend> RequestsSent { get; set; }
             
    }
}
