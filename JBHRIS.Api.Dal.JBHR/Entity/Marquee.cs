﻿using System;
using System.Collections.Generic;

namespace JBHRIS.Api.Dal.JBHR
{
    public partial class Marquee
    {
        public int Id { get; set; }
        public string DisplayText { get; set; }
        public bool? Enable { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
