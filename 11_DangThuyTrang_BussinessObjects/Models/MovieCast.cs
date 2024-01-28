﻿using System;
using System.Collections.Generic;

namespace _11_DangThuyTrang_BussinessObjects.Models
{
    public partial class MovieCast
    {
        public int? MovieId { get; set; }
        public int? CastId { get; set; }

        public virtual Cast Cast { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
