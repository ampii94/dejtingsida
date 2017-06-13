using System;
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
        public int UserId { get; set;}
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }
        public string About { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

    }
}
