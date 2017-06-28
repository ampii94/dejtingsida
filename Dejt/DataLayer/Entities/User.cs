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
        public virtual int UserId { get; set;}
        public virtual string Email { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Password { get; set; }
        public virtual string About { get; set; }
        public virtual string Description { get; set; }
        public virtual string PictureUrl { get; set; }
        public virtual string Gender { get; set; }
        public virtual string PersonNummer { get; set; }

        public virtual bool Visible { get; set; }

    }
}
