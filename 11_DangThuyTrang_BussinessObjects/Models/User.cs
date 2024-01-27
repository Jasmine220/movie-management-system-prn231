using System;
using System.Collections.Generic;

namespace _11_DangThuyTrang_BussinessObjects.Models
{
    public partial class User
    {
        public User()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool? Status { get; set; }
        public int? RoleId { get; set; }

        public virtual Account IdNavigation { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
