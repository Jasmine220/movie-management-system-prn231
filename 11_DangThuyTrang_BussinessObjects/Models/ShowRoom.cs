using System;
using System.Collections.Generic;

namespace _11_DangThuyTrang_BussinessObjects.Models
{
    public partial class ShowRoom
    {
        public ShowRoom()
        {
            Seats = new HashSet<Seat>();
            ShowTimes = new HashSet<ShowTime>();
            Theaters = new HashSet<Theater>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? NumberSeat { get; set; }
        public string Type { get; set; }
        public bool? Status { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Seat> Seats { get; set; }
        public virtual ICollection<ShowTime> ShowTimes { get; set; }
        public virtual ICollection<Theater> Theaters { get; set; }
    }
}
