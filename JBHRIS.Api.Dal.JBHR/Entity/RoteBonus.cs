﻿using System;
using System.Collections.Generic;

namespace JBHRIS.Api.Dal.JBHR
{
    public partial class RoteBonus
    {
        public int Auto { get; set; }
        public string Rote { get; set; }
        public string SalCode { get; set; }
        public string StrB { get; set; }
        public string StrE { get; set; }
        public decimal Value1 { get; set; }
        public decimal Value2 { get; set; }
        public decimal Amt { get; set; }
        public DateTime KeyDate { get; set; }
        public string KeyMan { get; set; }
        public bool Check1 { get; set; }
        public bool Check2 { get; set; }
        public bool Check3 { get; set; }
        public bool Check4 { get; set; }
        public bool Check5 { get; set; }
        public bool Check6 { get; set; }
        public int Sort { get; set; }
        public string Salfunction { get; set; }

        public virtual Rote RoteNavigation { get; set; }
        public virtual Salcode SalCodeNavigation { get; set; }
    }
}
