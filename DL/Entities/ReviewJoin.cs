﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class ReviewJoin
    {
        public int Id { get; set; }
        public int ReviewId { get; set; }
        public int RestaurantId { get; set; }
        public int UserId { get; set; }

        public virtual Restaurant Restaurant { get; set; }
        public virtual Review Review { get; set; }
        public virtual User User { get; set; }
    }
}
