using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Friend
    {
        public int FriendId { get; set; }
        public int SenderId { get; set; }
        public int RecieverId { get; set; }
        public bool Accepted { get; set; }
        [ForeignKey("RecieverId")]
        [InverseProperty("RequestsRecieved")]
        public User Reciever { get; set; }
        [ForeignKey("SenderId")]
        [InverseProperty("RequestsSent")]
        public User Sender { get; set; }
    }
}
