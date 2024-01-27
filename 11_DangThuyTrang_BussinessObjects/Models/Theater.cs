using System;
using System.Collections.Generic;

namespace _11_DangThuyTrang_BussinessObjects.Models
{
    public partial class Theater
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Hotline { get; set; }
        public string Address { get; set; }
        public int? ShowroomId { get; set; }

        public virtual ShowRoom Showroom { get; set; }
    }
}
