﻿using System;
using System.Collections.Generic;

namespace JBHRIS.Api.Dal.JBHR
{
    public partial class EffsManginterview
    {
        public int AutoKey { get; set; }
        public int? Yy { get; set; }
        public int? Seq { get; set; }
        public string Nobr { get; set; }
        public string Mangnobr { get; set; }
        public string Interid { get; set; }
        public string Note { get; set; }
        public DateTime? KeyDate { get; set; }
    }
}
