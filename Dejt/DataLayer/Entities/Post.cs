using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Post
    {
        public int PostId { get; set; }
        public int SenderId { get; set; }
        public int RecieverId { get; set; }
        public string Content { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        [ForeignKey("ReciverId")]
        [InverseProperty("PostsRecieved")]
        public User Reciever { get; set; }
        [ForeignKey("SenderId")]
        [InverseProperty("PostsSent")]
        public User Sender { get; set; }
    }
}
