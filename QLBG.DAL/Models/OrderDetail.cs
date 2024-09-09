﻿using System;
using System.Collections.Generic;

#nullable disable

namespace QLBG.DAL.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int ShoeDetailId { get; set; }
        public int OrderId { get; set; }
        public int Amount { get; set; }

        public virtual Order Order { get; set; }
        public virtual ShoeDetail ShoeDetail { get; set; }
        public virtual Comment Comment { get; set; }
    }
}
