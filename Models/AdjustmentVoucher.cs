﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndAD.Models
{
    public class AdjustmentVoucher
    {
        public int id { get; set; }
        public int StockAdjustmentId { get; set; }
        public DateTime date { get; set; }
        public int EmployeeId { get; set; }
        public string reason { get; set; }

        public virtual StockAdjustment StockAdjustment { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
