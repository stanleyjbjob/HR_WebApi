﻿using System;
using System.Collections.Generic;

namespace JBHRIS.Api.Dal.JBHR
{
    public partial class UOrder
    {
        public string QName { get; set; }
        public string QField { get; set; }
        public string QAsc { get; set; }
        public string Usernobr { get; set; }
        public string Formname { get; set; }
        public decimal Seq { get; set; }
        public string System { get; set; }
    }
}
